var apiURL = `${server.apiClientSideAddress}/api/`;

var app = new Vue(
    {
        el: '.poke-grid',
            data: {
                loadingMessage: 'Loading pokédex...'
            },
            created: function () {
                var self = this;
            },
        methods: {

        }
    });