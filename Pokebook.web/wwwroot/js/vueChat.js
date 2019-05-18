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
                var jsonObject = JSON.stringify({ chatId: chatId });
                // opslaan - ajax configuratie
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var ajaxConfig = {
                    method: 'PUT',
                    body: jsonObject,
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
            },
            loadMoreMessages: function () {
                self = this;
                var chatId = document.getElementById("chatId").value;
                var numberOfShownMessages = document.getElementById("messagesList").getElementsByTagName("li").length;
                fetch(`${apiURL}Messages/range/${chatId}/${numberOfShownMessages}/${20}`)
                    .then(res => res.json())
                    .then(function (res) {
                        var list = Object.assign([], res).reverse();//object omzetten naar array van objecten en omdraaien
                        for (var i = 0; i < list.length; i++) self.createNewBubble(list[i]);
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            createNewBubble: function (message) {
                var userId = document.getElementById("userId").value;
                //aanmaak nodige HTML elementen
                var li = document.createElement("li");
                var p = document.createElement("p");
                var spanTime = document.createElement("span");
                var spanLetter = document.createElement("span");
                var br = document.createElement("br");

                //inhoud van HTML elementen
                p.textContent = message.text;
                //if (message.senderId !== userId)
                    spanLetter.textContent = 'T';
                spanTime.textContent = message.sendDate;

                //li opvullen met andere HTML elementen
                if (message.senderId !== userId) li.appendChild(spanLetter);
                li.appendChild(p);
                if (message.senderId !== userId) li.appendChild(br);
                li.appendChild(spanTime);

                //classes geven aan HTML elementen en toevoegen aan messagesList
                spanLetter.setAttribute("class", "eersteLetter");
                spanTime.setAttribute("class", "time");

                if (message.senderId === userId) li.setAttribute("class", "bubble-me");
                else li.setAttribute("class", "bubble-other");
                var list = document.getElementById("messagesList");
                list.insertBefore(li, list.childNodes[0]);
            }
        }
    });