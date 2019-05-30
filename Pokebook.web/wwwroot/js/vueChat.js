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
            processSendMessage: function () {
                //var self = this;
                //var messageImage = self.addFormDataImage();
                //if (self.message !== "") {
                //    if (messageImage !== null) {
                //        var config = messageImage;
                //        let myRequest = new Request(`${apiURL}Messages/MessagePicture`, config);
                //        fetch(myRequest)
                //            .then(res => res.json())
                //            .then(function (res) {
                //                document.getElementById("newImage").value = "";
                //                self.fileToUpload = '';
                //                imageNameGlobal = res;
                //                self.sendMessage(res);
                //            })
                //            .catch(err => console.error('Fout: ' + err));
                //    }
                //    else self.sendMessage(null);
                //}
            },
            sendMessage: function (name) {
                //var self = this;
                //var jsonObject = JSON.stringify({ chatId: self.chatId, senderId: self.userId, text: self.message, sendDate: self.getTime(), imageName: name });

                //// opslaan - ajax configuratie
                //var ajaxHeaders = new Headers();
                //ajaxHeaders.append("Content-Type", "application/json");
                //var ajaxConfig = {
                //    method: 'POST',
                //    body: jsonObject,
                //    headers: ajaxHeaders
                //};

                //let myRequest = new Request(`${apiURL}Messages`, ajaxConfig);
                //fetch(myRequest)
                //    .then(res => res.json(), self.updateMessageCount())
                //    .catch(err => console.error('Fout: ' + err));
            },
            updateMessageCount: function () {
                //var self = this;
                //var jsonObject = JSON.stringify({ chatId: self.chatId });
                //// opslaan - ajax configuratie
                //var ajaxHeaders = new Headers();
                //ajaxHeaders.append("Content-Type", "application/json");
                //var ajaxConfig = {
                //    method: 'PUT',
                //    body: jsonObject,
                //    headers: ajaxHeaders
                //};
                //let myRequest = new Request(`${apiURL}Chats/Addition/${self.chatId}`, ajaxConfig);
                //fetch(myRequest)
                //    .then(res => res.json())
                //    .catch(err => console.error('Fout: ' + err));
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
                var img = document.createElement("img");
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
                if (message.imageName !== null) {
                    img.src = `${apiURL}messages/messagePicture/${message.imageName}`;
                    img.alt = message.imageName;
                    img.title = message.imageName;
                    li.append(img);
                }
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
                var errorOutput = self.isImageValid();//check als er een geldige image is.
                if (errorOutput === "") {
                    var data = new FormData();
                    data.append('file', self.fileToUpload);
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
                            if (res.status !== 400) self.updateChatInfo();//wanneer de image is geupload en de naam is ontvangen wordt de chatRow geupdate
                        })
                        .catch(err => console.error('Fout: ' + err));
                }
                else {
                    if (errorOutput !== "" && errorOutput !== "no image selected") {
                        //enkel wanneer er een image is worden de fouten ervan getoond
                        document.getElementById("chatSettingsError").innerHTML = errorOutput;
                    }
                    self.updateChatInfo();
                }
            },
            prepareFileUpload: function () {
                var self = this;
                self.fileToUpload = "";
                self.fileToUpload = document.getElementById("Chat_Image").files[0];
            },
            updateChatInfo: function () {
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
            isImageValid: function () {
                var self = this;
                if (self.fileToUpload === undefined || self.fileToUpload === "") return "no image selected";
                if (self.fileToUpload['type'].split('/')[0] !== 'image') return "no valid image";
                if (self.fileToUpload.size > 3145728) return "image is larger than 3 MB";//max file size van 3MB
                return "";
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
                            self.updateNumberOfUsers(res.length);
                            for (var i = 0; i < res.length; i++) self.groupMembers.push(res[i]);
                        })
                        .catch(err => console.error('Fout: ' + err));
            },
            doNotAddUser: function (e) {
                var self = this;
                var clickedUser = e.target.getAttribute('data-user');
                self.usersToAdd.pop(clickedUser);
                self.users.push(clickedUser);
            },
            deleteUserFromChat: function (e) {
                var self = this;
                var clickedUser = e.target.getAttribute('data-user');
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var todelete = self.getMemberByUserName(clickedUser).id;
                if (todelete !== null) {
                    var ajaxConfig = {
                        method: 'DELETE',
                        headers: ajaxHeaders
                    };
                    let myRequest = new Request(`${apiURL}UserChats/DeleteUserFromChat/${self.chatId}/${todelete}`, ajaxConfig);
                    fetch(myRequest)
                        .then(res => res.json())
                        .then(function (res) {
                            self.users.push(clickedUser);
                            self.groupMembers.pop(self.getMemberByUserName(clickedUser));
                            self.updateNumberOfUsers(-1);
                            console.log(el);
                        })
                        .catch(err => console.error('Fout: ' + err));
                }
            },
            updateNumberOfUsers: function (value) {
                var self = this;
                var text = document.querySelectorAll('[data-id="' + self.chatId + '"] .numberOfUsers')[0].textContent;
                var number = parseInt(text.slice(1, -1));
                number += value;
                document.querySelectorAll('[data-id="' + self.chatId + '"] .numberOfUsers')[0].innerHTML = "(" + number + ")";
            },
            getMemberByUserName: function (userName) {
                var self = this;
                for (var i = 0; i < self.groupMembers.length; i++) {
                    if (self.groupMembers[i].userName === userName) return self.groupMembers[i];
                }
                return null;
            },
            addFormDataImage: function () {
                var self = this;
                var data = new FormData();
                data.append('file', self.fileToUpload);
                if (self.fileToUpload !== "") {
                    var ajaxConfig = {
                        method: 'POST',
                        body: data
                    };
                    return ajaxConfig;
                }
                return null;
            }
        }
    });