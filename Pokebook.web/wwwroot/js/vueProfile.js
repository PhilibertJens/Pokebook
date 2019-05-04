var apiURL = 'https://localhost:44321/api/';

var app = new Vue(
    {
        el: '#profileInfo',
        data: {
            loadingMessage: 'Loading info...',
            posts: null,
            username: '',
            firstname: '',
            lastname: ''
        },
        methods: {
            getUserInfo: function (e) {
                this.processNavigation(e);
                document.querySelector("#userInfo").removeAttribute("hidden");
                document.querySelector("#editPencil").classList.add("editUserInfo");
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
                items = document.querySelectorAll(".information input");
                for (i = 0; i < items.length; i++) {
                    items[i].disabled = true;
                }

                items = document.querySelectorAll(".links li");
                for (i = 0; i < items.length; i++) {
                    items[i].classList.remove("active");
                }
                e.target.classList.add("active");
            },
            editMode: function (e) {
                var currentPage = e.target.className;
                var items = "";
                switch (currentPage) {
                    case "editUserInfo":
                        items = document.querySelectorAll("#userInfo input");
                        for (i = 0; i < items.length; i++) {
                            items[i].disabled = false;
                        }
                        break;
                    case "editPokeInfo":
                        break;
                    case "editFriendInfo":
                        break;
                    default:
                        break;
                }
            },
            saveUserInfo: function (e) {
                var userId = document.getElementById("userId").value;
                var profileObject = JSON.stringify({ id: userId, userName: this.username, firstName: this.firstname, lastName: this.lastname });
                console.log(profileObject);
                // opslaan - ajax configuratie
                var ajaxHeaders = new Headers();
                ajaxHeaders.append("Content-Type", "application/json");
                var ajaxConfig = {
                    method: 'PUT',
                    body: profileObject,
                    headers: ajaxHeaders
                };

                let myRequest = new Request(`${apiURL}Users/UpdateUserInfo`, ajaxConfig);
                fetch(myRequest)
                    .then(res => res.json())
                    .catch(err => console.error('Fout: ' + err));
            }
        }
    });