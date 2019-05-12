var apiURL = 'https://localhost:44321/api/';

var app = new Vue(
    {
        el: '.friendRequests',
        data: {
            loadingMessage: 'Loading friendRequests...',
            friendRequests: null,
            users: null,
            userId: '',
            me: null,
            numberOfRequests: ''
        },
        created: function() {
            var self = this;
            self.userId = document.getElementById("userId").value;
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
                                console.log(self.me.userName);
                            }
                        });
                        self.users = allExceptMe;
                        console.log(self.users);
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            getMyUserName: function () {
                self = this;
                fetch(`${apiURL}Users/Simple/${self.userId}`)
                    .then(res => res.json())
                    .then(function (res) {
                        self.me = res;
                        self.getUsers();
                    })
                    .catch(err => console.error('Fout: ' + err));
            }
        }
    });