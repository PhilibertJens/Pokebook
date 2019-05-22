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
            users: [],
            usersMetId: [],
            groupMembers: [],
            myUserName: '',
            chatName: '',
            chatImage: '',
            fileToUpload: '',
            chat: '',
            chatPreview: '/images/preview.png',
            usersToAdd: []
        },
        created: function () {
            var self = this;
            self.userId = document.getElementById("userId").value;//v-model werkt niet met hidden types
            self.chatId = document.getElementById("chatId").value;
            self.myUserName = document.querySelector('[data-username]').getAttribute('data-username');
            self.chatName = document.getElementById("Chat_Name").value;
            self.getNonChatUsers();
            self.getGroupMembers();
            self.chat = self.getChatById();
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
                    if (senderUsername === null) spanLetter.textContent = "removed user";
                    //spanLetter.textContent = senderUsername.charAt(0);
                    else spanLetter.textContent = senderUsername;
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
            getNonChatUsers: function () {
                var self = this;
                fetch(`${apiURL}Users/RemainingUsersSimple/${self.chatId}`)
                    .then(res => res.json())
                    .then(function (res) {
                        var allExceptMe = [];
                        var allExceptMeWithId = [];
                        Object.keys(res).forEach(function (key) {
                            if (res[key].userName !== self.myUserName) {
                                allExceptMe.push(res[key].userName);
                                allExceptMeWithId.push(res[key]);
                            }
                        });
                        self.users = allExceptMe;
                        self.usersMetId = allExceptMeWithId;
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            getGroupMembers: function () {
                var self = this;
                fetch(`${apiURL}Users/ChatUsersSimple/${self.chatId}`)
                    .then(res => res.json())
                    .then(function (res) {
                        var allExceptMe = [];
                        Object.keys(res).forEach(function (key) {
                            if (res[key].userName !== self.myUserName) {
                                allExceptMe.push(res[key]);
                            }
                        });
                        self.groupMembers = allExceptMe;
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            getUserNameFromUser: function(id) {
                var self = this;
                for (var i = 0; i < self.groupMembers.length; i++) {
                    if (self.groupMembers[i].id === id) return self.groupMembers[i].userName;
                }
                for (i = 0; i < self.usersMetId.length; i++) {//als de user uit de chat is verwijderd wordt hij hier opgehaald
                    if (self.usersMetId[i].id === id) return self.usersMetId[i].userName;
                }
                return null;
            },
            uploadChatImage: function (e) {
                var self = this;
                var data = new FormData();
                data.append('file', self.fileToUpload);
                if (self.fileToUpload !== "") {
                    var ajaxConfig = {
                        method: 'POST',
                        body: data
                    };

                    let myRequest = new Request(`${apiURL}Chats/Uploads/ChatImage`, ajaxConfig);
                    fetch(myRequest)
                        .then(res => res.json())
                        .then(function (res) {
                            self.chatImage = res;//de naam van de image
                            document.getElementById("Chat_Image").value = "";
                            self.fileToUpload = '';
                            self.chatPreview = '/images/preview1.png';
                            if (res.status !== 400) self.updateChatInfo(true);//wanneer de image is geupload en de naam is ontvangen wordt de chatRow geupdate
                        })
                        .catch(err => console.error('Fout: ' + err));
                }
                else self.updateChatInfo(false);
            },
            prepareFileUpload: function () {
                var self = this;
                self.fileToUpload = self.$refs.file.files[0];
            },
            updateChatInfo: function (imageUploaded) {
                var self = this;
                document.getElementById("feedbackError").innerHTML = "";
                if (self.validCheck()) {
                    var jsonObject = JSON.stringify({ ChatId: self.chatId, ChatName: self.chatName, ChatImage: self.chatImage });
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
                            if (res.statusCode !== 404) {
                                document.querySelector("#ChatNameTitle").innerHTML = res.value.name;//h2 titel
                                document.querySelector('[data-id="' + self.chatId + '"]').innerHTML = res.value.name;//a-tag uit vc:chat-list
                                $('#myModal').modal('hide');
                            }
                            else document.getElementById("feedbackError").innerHTML = "No changes made";
                        })
                        .catch(err => console.error('Fout: ' + err));
                }
            },
            getChatById: function () {
                var self = this;
                fetch(`${apiURL}Chats/GetById/${self.chatId}`)
                    .then(res => res.json())
                    .then(function (res) {
                        self.chatImage = res.image;
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            validCheck: function () {
                var items = document.querySelectorAll(".chatSettings span");
                for (i = 0; i < items.length; i++) {
                    if (items[i].textContent !== "") return false;
                }
                var el = document.getElementById('Chat_Name').value;
                return el !== "";//returned true als de waarde niet leeg is
            },
            getSelectedUser: function (e) {
                var self = this;
                var name = e.target.value;
                self.usersToAdd.push(name);
                for (var i = 0; i < self.users.length; i++) {
                    if (self.users[i] === name) self.users.splice(i, 1);
                }
                document.getElementById("userListValue").value = "";
            },
            addUsersToChat: function (e) {
                var self = this;
                    var jsonObject = JSON.stringify({ ChatId: self.chatId, Users: self.usersToAdd });
                    // opslaan - ajax configuratie
                    var ajaxHeaders = new Headers();
                    ajaxHeaders.append("Content-Type", "application/json");
                    var ajaxConfig = {
                        method: 'POST',
                        body: jsonObject,
                        headers: ajaxHeaders
                    };

                let myRequest = new Request(`${apiURL}userchats/AddUsersToChat`, ajaxConfig);
                    fetch(myRequest)
                        .then(res => res.json())
                        .then(function (res) {
                            self.usersToAdd = [];
                            $('#myModal').modal('hide');
                        })
                        .catch(err => console.error('Fout: ' + err));
            },
            doNotAddUser: function (e) {
                var self = this;
                var clickedUser = e.target.getAttribute('data-user');
                self.usersToAdd.pop(clickedUser);
                self.users.push(clickedUser);
            }
        }
    });