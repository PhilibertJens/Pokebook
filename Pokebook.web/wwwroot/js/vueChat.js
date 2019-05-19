var apiURL = 'https://localhost:44321/api/';

var app = new Vue(
    {
        el: '#chat',
        data: {
            loadingMessage: 'Loading messages with Vue and SignalR...',
            messages: null,
            message: '',
            userId: '',
            chatId: '',
            users: null,
            myUserName: '',
            chatName: '',
            chatImage: '',
            file: '',
            encodedImage: ''
        },
        created: function () {
            var self = this;
            self.userId = document.getElementById("userId").value;//v-model werkt niet met hidden types
            self.chatId = document.getElementById("chatId").value;
            self.myUserName = document.querySelector('[data-username]').getAttribute('data-username');
            self.chatName = document.getElementById("Chat_Name").value;
            self.getGroupMembers();
        },
        methods: {
            sendMessage: function () {
                var self = this;
                var jsonObject = JSON.stringify({ chatId: self.chatId, senderId: self.userId, text: self.message, sendDate: self.getTime()});
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
                var jsonObject = JSON.stringify({ chatId: self.chatId });
                // opslaan - ajax configuratie
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var ajaxConfig = {
                    method: 'PUT',
                    body: jsonObject,
                    headers: ajaxHeaders
                };
                let myRequest = new Request(`${apiURL}Chats/Addition/${self.chatId}`, ajaxConfig);
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
                var numberOfShownMessages = document.getElementById("messagesList").getElementsByTagName("li").length;
                fetch(`${apiURL}Messages/range/${self.chatId}/${numberOfShownMessages}/${20}`)
                    .then(res => res.json())
                    .then(function (res) {
                        var list = Object.assign([], res).reverse();//object omzetten naar array van objecten en omdraaien
                        for (var i = 0; i < list.length; i++) self.createNewBubble(list[i]);
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            createNewBubble: function (message) {
                var self = this;
                //aanmaak nodige HTML elementen
                var li = document.createElement("li");
                var p = document.createElement("p");
                var spanTime = document.createElement("span");
                var spanLetter = document.createElement("span");
                var br = document.createElement("br");

                //inhoud van HTML elementen
                p.textContent = message.text;
                if (message.senderId !== self.userId) {
                    var senderUsername = self.getUserNameFromUser(message.senderId);
                    spanLetter.textContent = senderUsername.charAt(0);
                }
                spanTime.textContent = message.sendDate;

                //li opvullen met andere HTML elementen
                if (message.senderId !== self.userId) li.appendChild(spanLetter);
                li.appendChild(p);
                if (message.senderId !== self.userId) li.appendChild(br);
                li.appendChild(spanTime);

                //classes geven aan HTML elementen en toevoegen aan messagesList
                spanLetter.setAttribute("class", "eersteLetter");
                spanTime.setAttribute("class", "time");

                if (message.senderId === self.userId) li.setAttribute("class", "bubble-me");
                else li.setAttribute("class", "bubble-other");
                var list = document.getElementById("messagesList");
                list.insertBefore(li, list.childNodes[0]);
            },
            getGroupMembers: function () {
                var self = this;
                fetch(`${apiURL}Users/Simple`)
                    .then(res => res.json())
                    .then(function (res) {
                        var allExceptMe = [];
                        Object.keys(res).forEach(function (key) {
                            if (res[key].userName !== self.myUserName) {
                                allExceptMe.push(res[key]);
                            }
                        });
                        self.users = allExceptMe;
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            getUserNameFromUser: function(id) {
                var self = this;
                for (var i = 0; i < self.users.length; i++) {
                    if (self.users[i].id === id) return self.users[i].userName;
                }
                return null;
            },
            saveChatInfo: function (e) {
                var self = this;
                //self.encodeImage(self.file);
                var data = new FormData();
                data.append('file', self.file);
                if (self.file !== "") {
                    var ajaxConfig = {
                        method: 'POST',
                        body: data
                    };

                    let myRequest = new Request(`${apiURL}Chats/Uploads/ChatImage`, ajaxConfig);
                    fetch(myRequest)
                        .then(res => res.json())
                        .then(function (res) {
                            if(res.status !== 400) self.updateChatInfo(res);//wanneer de image is geupload en de naam is ontvangen wordt de chatRow geupdate
                        })
                        .catch(err => console.error('Fout: ' + err));
                }
                else self.updateChatInfo(null);
            },
            encodeImage(input) {
                if (input) {
                    const reader = new FileReader();
                    reader.onload = (e) => {
                        this.base64Img = e.target.result;
                    };
                    reader.readAsDataURL(input);
                }
            },
            handleFileUpload: function () {
                var self = this;
                self.file = self.$refs.file.files[0];
            },
            updateChatInfo: function (imageName) {
                var self = this;
                var jsonObject = JSON.stringify({ ChatId: self.chatId, ChatName: self.chatName, ChatImage: imageName });
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var ajaxConfig = {
                    method: 'POST',
                    body: jsonObject,
                    headers: ajaxHeaders
                };

                var myRequest = new Request(`${apiURL}Chats/ChatSettings`, ajaxConfig);
                fetch(myRequest)
                    .then(res => res.json())
                    .then(function (res) {
                        document.querySelector("#ChatNameTitle").innerHTML = res.value.name;//h2 titel
                        document.querySelector('[data-id="' + self.chatId + '"]').innerHTML = res.value.name;//a-tag uit vc:chat-list
                    })
                    .catch(err => console.error('Fout: ' + err));
            }
        }
    });