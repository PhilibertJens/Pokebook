var apiURL = 'https://localhost:44321/api/';

var app = new Vue(
    {
        el: '#profileInfo',
        data: {
            loadingMessage: 'Loading info...',
            posts: null,
            username: '',
            firstname: '',
            lastname: '',
            favPoke: '',
            favPokegame: ''
        },
        created: function () {
            var self = this;
            self.username = document.getElementsByName('UserName')[0].value;
            self.firstname = document.getElementsByName('FirstName')[0].value;
            self.lastname = document.getElementsByName('LastName')[0].value;
            self.favPoke = document.getElementsByName('FavoritePokemon')[0].value;//om jquery validation te laten werken moest dit hetzelfde zijn als de Property Name
            self.favPokegame = document.getElementsByName('FavoritePokemonGame')[0].value;
        },
        methods: {
            getUserInfo: function (e) {
                this.processNavigation(e, "editUserInfo");
                document.querySelector("#userInfo").removeAttribute("hidden");
            },
            getPokeInfo: function (e) {
                this.processNavigation(e, "editPokeInfo");
                document.querySelector("#pokeInfo").removeAttribute("hidden");
            },
            getFriendsInfo: function (e) {
                this.processNavigation(e, "editFriendInfo");
                document.querySelector("#friendInfo").removeAttribute("hidden");
            },
            processNavigation: function (e, classToAdd) {
                document.querySelector("#editPencil").className = "";
                document.querySelector("#editPencil").classList.add(classToAdd);
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
                        break;
                    case "editPokeInfo":
                        items = document.querySelectorAll("#pokeInfo input");
                        break;
                    case "editFriendInfo":
                        items = document.querySelectorAll("#friendInfo input");
                        break;
                    default:
                        break;
                }
                for (i = 0; i < items.length; i++) {
                    items[i].disabled = false;
                }
            },
            saveUserInfo: function (e) {
                items = document.querySelectorAll("#userInfo span");
                var isValid = true;
                for (i = 0; i < items.length; i++) {
                    if (items[i].textContent !== "") isValid = false;
                }
                if (isValid) {
                    //moet nog gevalideerd worden
                    var userId = document.getElementById("userId").value;
                    var profileObject = JSON.stringify({ id: userId, userName: this.username, firstName: this.firstname, lastName: this.lastname });
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
            },
            savePokeInfo: function (e) {
                items = document.querySelectorAll("#pokeInfo span");
                var isValid = true;
                for (i = 0; i < items.length; i++) {
                    if (items[i].textContent !== "") isValid = false;
                }
                if (isValid) {//pas wanneer er geen errormessage in de span staat
                    var userId = document.getElementById("userId").value;
                    var profileObject = JSON.stringify({ id: userId, favoritePokemon: this.favPoke, favoritePokemonGame: this.favPokegame });
                    // opslaan - ajax configuratie
                    var ajaxHeaders = new Headers();
                    ajaxHeaders.append("Content-Type", "application/json");
                    var ajaxConfig = {
                        method: 'PUT',
                        body: profileObject,
                        headers: ajaxHeaders
                    };

                    let myRequest = new Request(`${apiURL}Users/UpdatePokeInfo`, ajaxConfig);
                    fetch(myRequest)
                        .then(res => res.json())
                        .catch(err => console.error('Fout: ' + err));
               }
            }
        }
    });