var app = new Vue(
    {
        el: '#profileInfo',
        data: {
            loadingMessage: 'Loading info...',
            posts: null
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
                items = document.querySelectorAll(".information div");
                for (i = 0; i < items.length; i++) {
                    items[i].setAttribute("hidden", true);
                }
                items = document.querySelectorAll(".links li");
                for (i = 0; i < items.length; i++) {
                    items[i].classList.remove("active");
                }
                e.target.classList.add("active");
            }
        }
    });