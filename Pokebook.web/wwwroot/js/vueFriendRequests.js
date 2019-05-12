var apiURL = 'https://localhost:44321/api/';

var app = new Vue(
    {
        el: '.friendRequests',
        data: {
            loadingMessage: 'Loading friendRequests...',
            friendRequests: null,
        },
        created: function() {
            var self = this;
            self.fetchFriendRequests();
        },
        methods: {
            fetchFriendRequests: function () {
                self = this;
                var userId = document.getElementById("userId").value;
                console.log(`${apiURL}friendships/GetFriendsToApprove/${userId}`);
                fetch(`${apiURL}friendships/GetFriendsToApprove/${userId}`)
                    .then(res => res.json())
                    .then(function (requests) {
                        self.friendRequests = requests;
                        self.loadingMessage = 'Overview';
                        console.log(requests);
                    })
                    .catch(err => console.error('Fout: ' + err));
            }
        }
    });