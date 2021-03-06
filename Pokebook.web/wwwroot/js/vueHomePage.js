﻿var apiURL = `${server.apiClientSideAddress}/api/`;

var app = new Vue(
    {
        el: '.friendRequests',
        data: {
            loadingMessage: 'Loading friendRequests...',
            friendRequests: null,
            users: null,
            userId: '',
            me: null,
            profilePicture: "default.png",//als de pagina laadt is de profielfoto nog niet opgevraagd
            numberOfRequests: ''
        },
        created: function() {
            var self = this;
            self.userId = document.querySelector('[data-userId]').getAttribute('data-userId');
            self.getMyUserName();
            self.fetchFriendRequests();
        },
        methods: {
            fetchFriendRequests: function () {
                self = this;
                fetch(`${apiURL}friendships/GetFriendsToApprove/${self.userId}`)
                    .then(res => res.json())
                    .then(function (requests) {
                        self.friendRequests = requests;
                        self.numberOfRequests = Object.keys(requests).length;
                        if (self.numberOfRequests > 0) self.loadingMessage = 'Overview of your friend requests';
                        else self.loadingMessage = 'There are currently no friend requests';
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            approveFriendRequest: function (friend) {
                self = this;
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var ajaxConfig = {
                    method: 'PUT',
                    headers: ajaxHeaders
                };
                let myRequest = new Request(`${apiURL}Friendships/Approve/${friend.id}/${self.userId}`, ajaxConfig);
                fetch(myRequest)
                    .then(res => res.json())
                    .then(() => {
                            self.fetchFriendRequests();
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            ignoreFriendRequest: function (friend) {
                self = this;
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var ajaxConfig = {
                    method: 'DELETE',
                    headers: ajaxHeaders
                };
                let myRequest = new Request(`${apiURL}Friendships/Ignore/${friend.id}/${self.userId}`, ajaxConfig);
                fetch(myRequest)
                    .then(res => res.json())
                    .then(() => {
                        self.fetchFriendRequests();
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            getUsers: function () {
                self = this;
                fetch(`${apiURL}Users/Simple`)
                    .then(res => res.json())
                    .then(function (res) {
                        var allExceptMe = [];
                        Object.keys(res).forEach(function (key) {
                            if (res[key].userName !== self.me.userName) {
                                allExceptMe.push(res[key].userName);
                            }
                        });
                        self.users = allExceptMe;
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            getMyUserName: function () {
                self = this;
                fetch(`${apiURL}Users/SimpleProfile/${self.userId}`)
                    .then(res => res.json())
                    .then(function (res) {
                        self.me = res;
                        self.profilePicture = self.me.profilePicture;//Nu pas kunnen we de profielfoto tonen
                        console.log(self.profilePicture);
                        self.getUsers();//de users worden pas opgevraagd wanneer de username is ontvangen
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            getSelectedUser: function (e) {
                var self = this;
                var name = e.target.value;
                for (var i = 0; i < self.users.length; i++) {
                    if (self.users[i] === name) window.location = "/Profile/UserProfile/" + name;
                }
            }
        }
    });