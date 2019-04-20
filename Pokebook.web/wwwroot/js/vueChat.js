var apiURL = 'https://localhost:44321/api/';

var app = new Vue(
    {
        el: '#chat',
        data: {
            loadingMessage: 'Loading messages with Vue and SignalR...',
            messages: null
        },
        methods: {
            sendMessage: function () {
                var self = this;
                var message = document.getElementById("messageInput").value;
                var userId = document.getElementById("userId").value;
                var chatId = document.getElementById("chatId").value;
                var jsonObject = self.createJSONobject(chatId, userId, message);

                // opslaan - ajax configuratie
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var ajaxConfig = {
                    method: 'POST',
                    body: JSON.stringify(jsonObject),
                    //body: jsonString,
                    headers: ajaxHeaders
                };

                let myRequest = new Request(`${apiURL}Messages`, ajaxConfig);
                fetch(myRequest)
                    .then(res => res.json())
                    .catch(err => console.error('Fout: ' + err));
            },
            createJSONobject: function (chatId, userId, message) {
                var self = this;
                var jsonString = '{"chatId": "' + chatId + '","senderId": "' + userId + '","text": "'
                    + message + '","imageName": null,"sendDate": "' + self.getTime() + '","chat": null,"sender": null}';
                return JSON.parse(jsonString);
            },
            getTime: function () {
                var today = new Date();
                var date = today.getFullYear() + '-' + (today.getMonth() + 1) + '-' + today.getDate();
                var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
                return date + ' ' + time;
            }
        }
    });