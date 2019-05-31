var apiURL = 'https://localhost:44321/api/';

var app = new Vue(
    {
        el: '#profileInfo',
        data: {
            loadingMessage: 'Loading info...',
            userId: '',
            friendId: ''
        },
        created: function () {
            var self = this;
            self.userId = document.querySelector('[data-userId]').getAttribute('data-userId');
            self.friendId = document.getElementById("friendId").value;
        },
        methods: {
            getUserInfo: function (e) {
                this.processNavigation(e);
                document.querySelector("#userInfo").removeAttribute("hidden");
            },
            getPokeInfo: function (e) {
                this.processNavigation(e);
                document.querySelector("#pokeInfo").removeAttribute("hidden");
            },
            getFriendsInfo: function (e) {
                this.processNavigation(e);
                document.querySelector("#friendInfo").removeAttribute("hidden");
            },
            processNavigation: function (e) {
                items = document.querySelectorAll(".information article");
                for (i = 0; i < items.length; i++) {
                    items[i].setAttribute("hidden", true);
                }
                
                items = document.querySelectorAll(".links li");
                for (i = 0; i < items.length; i++) {
                    items[i].classList.remove("active");
                }
                e.target.classList.add("active");
            },
            editFriendStatus: function (e) {
                self = this;
                if (e.target.id === "addFriend") self.addFriend(e);
                else if (e.target.id === "removeFriend") self.removeFriend(e);
            },
            addFriend: function (e) {
                self = this;
                var friendShipObject = JSON.stringify({ IdRequester: self.userId, IdApprover: self.friendId, Accepted: 0 });
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var ajaxConfig = {
                    method: 'POST',
                    body: friendShipObject,
                    headers: ajaxHeaders
                };

                let myRequest = new Request(`${apiURL}Friendships/Add`, ajaxConfig);
                fetch(myRequest)
                    .then(res => res.json())
                    .then(() => {
                        var img = document.getElementById("addFriend");
                        img.src = '/images/friendRequestSend.png';
                        img.id = 'friendRequestSend';
                        img.alt = 'request send';
                        img.title = 'request send';
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            removeFriend: function (e) {
                self = this;
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var ajaxConfig = {
                    method: 'DELETE',
                    headers: ajaxHeaders
                };
                let myRequest = new Request(`${apiURL}Friendships/Ignore/${self.friendId}/${self.userId}`, ajaxConfig);
                fetch(myRequest)
                    .then(res => res.json())
                    .then(() => {
                        var img = document.getElementById("removeFriend");
                        img.src = '/images/addFriend.png';
                        img.id = 'addFriend';
                        img.alt = 'add friend';
                        img.title = 'add friend';
                    })
                    .catch(err => console.error('Fout: ' + err));
            }
        }
    });