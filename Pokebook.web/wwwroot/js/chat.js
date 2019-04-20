"use strict";
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g,
        "&gt;");
    var me = document.getElementById("user").value;
    var newMessage = "";

    //aanmaak nodige HTML elementen
    var li = document.createElement("li");
    var p = document.createElement("p");
    var spanTime = document.createElement("span");
    var spanLetter = document.createElement("span");
    var br = document.createElement("br");

    //inhoud van HTML elementen
    p.textContent = msg;
    spanLetter.textContent = user.charAt(0);
    spanTime.textContent = GetTime();

    //li opvullen met andere HTML elementen
    if (user !== me) li.appendChild(spanLetter);
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

document.getElementById("sendButton").addEventListener("click", function (event) {
    //var user = document.getElementById("userInput").value;
    var user = document.getElementById("user").value;
    var message = document.getElementById("messageInput").value;
    document.getElementById("messageInput").value = "";
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

function GetTime() {
    var today = new Date();
    var date = today.getFullYear() + '-' + (today.getMonth() + 1) + '-' + today.getDate();
    var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
    return date + ' ' + time;
}