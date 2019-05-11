var apiURL = 'https://localhost:44321/api/';

var app = new Vue(
    {
        el: '#profileInfo',
        data: {
            loadingMessage: 'Loading info...'
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
            addFriend: function (e) {
                console.log("friend added");
                //api request om nieuwe friendship aan te maken
                var friendId = document.getElementById("friendId").value;
                var userId = document.getElementById("userId").value;
                var friendShipObject = JSON.stringify({ IdRequester: userId, IdApprover: friendId, Accepted: 0 });
                // opslaan - ajax configuratie
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
                    .catch(err => console.error('Fout: ' + err));

            },
            removeFriend: function (e) {
                console.log("friend removed");
                //api request om bestaande friendship (met id) te verwijderen
            }
        }
    });