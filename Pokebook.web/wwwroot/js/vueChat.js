var apiURL = 'https://localhost:44321/api/';

var app = new Vue(
    {
        el: '#chat',
        data: {
            loadingMessage: 'Loading messages with Vue and SignalR...',
            messages: null,
            message: ''
        },
        methods: {
            sendMessage: function () {
                var self = this;
                var userId = document.getElementById("userId").value;//v-model werkt niet met hidden types
                var chatId = document.getElementById("chatId").value;
                var jsonObject = JSON.stringify({ chatId: chatId, senderId: userId, text: self.message, sendDate: self.getTime()});
                // opslaan - ajax configuratie
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var ajaxConfig = {
                    method: 'POST',
                    body: jsonObject,
                    headers: ajaxHeaders
                };
                
                let myRequest = new Request(`${apiURL}Messages`, ajaxConfig);
                fetch(myRequest)
                    .then(res => res.json(), self.updateMessageCount())
                    .catch(err => console.error('Fout: ' + err));
            },
            updateMessageCount: function () {
                var self = this;
                var chatId = document.getElementById("chatId").value;
                var jsonObject = JSON.parse('{"chatId": "' + chatId + '"}');
                // opslaan - ajax configuratie
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var ajaxConfig = {
                    method: 'PUT',
                    body: JSON.stringify(jsonObject),
                    //body: jsonString,
                    headers: ajaxHeaders
                };
                let myRequest = new Request(`${apiURL}Chats/Addition/${chatId}`, ajaxConfig);
                fetch(myRequest)
                    .then(res => res.json())
                    .catch(err => console.error('Fout: ' + err));
            },
            getTime: function () {
                var today = new Date();
                var date = today.getFullYear() + '-' + (today.getMonth() + 1) + '-' + today.getDate();
                var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
                return date + ' ' + time;
            }
        }
    });