"use strict";
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
var chatIds = [];
var chatIdSelector = document.querySelectorAll('[data-id]');
for (var i = 0; i < chatIdSelector.length; i++) {
    chatIds.push(chatIdSelector[i].getAttribute('data-id'));
}

setTimeout(function () {
    for (var i = 0; i < chatIds.length; i++) {
        connection.invoke("JoinChat", chatIds[i]).catch(function (err) {
            return console.error(err.toString());
    });
    }
}, 1000);


connection.on("ReceiveNotification", function (user, message, chatId) {
    var myUsername = document.querySelectorAll('[data-username]')[0].getAttribute('data-username');
    console.log(myUsername);
    if (user !== myUsername) {
        var chat = document.querySelectorAll('[data-id="' + chatId + '"]');
        var span = chat[0].querySelector(".badge");//er is maar 1 span met class badge
        var numberOfMessages = span.textContent;
        if (numberOfMessages === "") numberOfMessages = 1;
        else numberOfMessages = parseInt(numberOfMessages) +1;
        span.innerHTML = numberOfMessages;
        document.getElementsByClassName("layoutBadge")[0].style.display = "block";
    }
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});