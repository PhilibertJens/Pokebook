var app = new Vue(
    {
        el: '#chat',
        data: {
            loadingMessage: 'Loading messages with Vue and SignalR...',
            messages: null
        }
    });