"use strict";
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
var chatId = [];
var chatIds = document.querySelectorAll('[data-id]');
for (var i = 0; i < chatIds.length; i++) {
    chatId.push(chatIds[i].getAttribute('data-id'));
}

setTimeout(function () {
    for (var i = 0; i < chatId.length; i++) {
        connection.invoke("JoinChat", chatId[i]).catch(function (err) {
            return console.error(err.toString());
    });
    }
}, 1000);


connection.on("ReceiveNotification", function (user, message, chatId) {
    var chat = document.querySelectorAll('[data-id="' + chatId + '"]');
    var span = chat[0].querySelector(".badge");//er is maar 1 span met class badge
    var numberOfMessages = span.textContent;
    if (numberOfMessages === "") numberOfMessages = 1;
    else numberOfMessages = parseInt(numberOfMessages) +1;
    span.innerHTML = numberOfMessages;
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});