document.querySelector('.chat #messageInput').scrollIntoView({
    behavior: 'smooth'
});

var apiURL = 'https://localhost:44321/api/';

"use strict";
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
var chatId = document.getElementById("chatId").value;
setTimeout(function () {//als er niet gewacht wordt dan wordt de JoinChat al gedaan voordat de chathub connection is gemaakt
    //do something once
    connection.invoke("JoinChat", chatId).catch(function (err) {
        return console.error(err.toString());
    });
}, 1000);

connection.on("ReceiveMessage", function (user, message, imageName) {
    //enkel users die in dezelfde group (chat) zitten zullen dit ontvangen
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g,
        "&gt;");
    var me = document.querySelector('[data-username]').getAttribute('data-username');

    //aanmaak nodige HTML elementen
    var li = document.createElement("li");
    var p = document.createElement("p");
    var img = document.createElement("img");
    var spanTime = document.createElement("span");
    var spanLetter = document.createElement("span");
    var br = document.createElement("br");

    //inhoud van HTML elementen
    p.textContent = msg;
    //spanLetter.textContent = user.charAt(0);
    spanLetter.textContent = user;
    spanTime.textContent = GetTime();

    //li opvullen met andere HTML elementen
    if (user !== me) li.appendChild(spanLetter);
    //Je kunt hier niet nagaan welke image is geüpload
    if (imageName !== null) {
        img.src = "https://localhost:44321/api/messages/messagePicture/" + imageName;
        li.append(img);
    }
    li.appendChild(p);
    if (user !== me) li.appendChild(br);
    li.appendChild(spanTime);

    //classes geven aan HTML elementen en toevoegen aan messagesList
    spanLetter.setAttribute("class", "eersteLetter");
    spanTime.setAttribute("class", "time");

    if (user === me) li.setAttribute("class", "bubble-me");
    else li.setAttribute("class", "bubble-other");
    document.getElementById("messagesList").appendChild(li);
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});

function requestFormData() {
    var data = new FormData();
    var fileToUpload = document.forms['sendForm']['newImage'].files[0];
    data.append('file', fileToUpload);
    if (fileToUpload !== undefined) {
        var ajaxConfig = {
            method: 'POST',
            body: data
        };
        return ajaxConfig;
    }
    return null;
}

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.querySelector('[data-username]').getAttribute('data-username');
    var message = document.getElementById("messageInput").value;
    var chatId = document.getElementById("chatId").value;
    var userId = document.getElementById("userId").value;
    var messageImage = requestFormData();
    if (messageImage !== null) {
        var config = messageImage;
        let myRequest = new Request(`${apiURL}Messages/MessagePicture`, config);
        fetch(myRequest)
            .then(res => res.json())
            .then(function (res) {
                document.getElementById("newImage").value = "";
                document.forms['sendForm']['newImage'].files[0] = "";
                sendMessageQuery(user, message, chatId, res, userId);
            })
            .catch(err => console.error('Fout: ' + err));
    }
    else sendMessageQuery(user, message, chatId, null, userId);

    document.getElementById("messageInput").value = "";
    event.preventDefault();
});

function sendMessageQuery(user, message, chatId, image, userId) {
    console.log("We zitten hier. Message: " + message);
    if (isValid(message, image)) {
        var jsonObject = JSON.stringify({ chatId: chatId, senderId: userId, text: message, sendDate: GetTime(), imageName: image });

        // opslaan - ajax configuratie
        var ajaxHeaders = new Headers();
        ajaxHeaders.append("Content-Type", "application/json");
        var ajaxConfig = {
            method: 'POST',
            body: jsonObject,
            headers: ajaxHeaders
        };

        let myRequest = new Request(`${apiURL}Messages/NewMessage`, ajaxConfig);
        fetch(myRequest)
            .then(res => res.json())
            .catch(err => console.error('Fout: ' + err));

        connection.invoke("SendMessage", user, message, chatId, image).catch(function (err) {
            return console.error(err.toString());
        });
    }
}

function isValid(message, image) {
    return !(message === "" && image === null);
}

function GetTime() {
    var today = new Date();
    var date = today.getFullYear() + '-' + (today.getMonth() + 1) + '-' + today.getDate();
    var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
    return date + ' ' + time;
}