var apiURL = `${server.apiClientSideAddress}/api/`;

var app = new Vue(
    {
        el: '#pokedex',
        data: {
            loadingMessage: 'Loading pokédex...',
            userId: '',
            userValue: '',
            listPokemonCatchesToEdit: [],
            listDeletedPokemonCatches: []
        },
        created: function () {
            var self = this;
            self.userId = document.querySelector('[data-userId]').getAttribute('data-userId');
            self.getAllPokemonCatches();
        },
        methods: {
            getAllPokemonCatches: function (e) {
                var self = this;
                fetch(`${apiURL}PokemonCatches/GetMyPokemon/${self.userId}`)
                    .then(res => res.json())
                    .then(function (pokemonList) {
                        self.listPokemonCatchesToEdit = pokemonList;
                        localStorage.setItem("myPokemon", JSON.stringify(pokemonList));
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            updatePokemonCatchesList: function (e) {
                var self = this;
                self.listPokemonCatchesToEdit = self.getFromLocalStorage("myPokemon");

                for (var i = 0; i < self.listPokemonCatchesToEdit.length; i++) {
                    var name = self.listPokemonCatchesToEdit[i].pokemon.name.toLowerCase();
                    name = name.substring(0, self.userValue.length);
                    if (name !== self.userValue) {
                        self.listDeletedPokemonCatches.push(self.listPokemonCatchesToEdit.splice(i, 1));
                        i--;
                    }
                }
                self.parameterCheck();
            },
            getFromLocalStorage: function (storageItem) {
                if (typeof (Storage) !== "undefined") {
                    return JSON.parse(localStorage.getItem(storageItem));
                }
            },
            parameterCheck: function () {
                var self = this;
                var term = self.userValue;
                var re = new RegExp(/^(\w+)([|])(\w+)$/);
                if (re.test(term)) {
                    console.log("paramter na |");
                    var param = self.userValue.substring(self.userValue.indexOf('|') + 1);
                    console.log(param);
                }
            }
        }
    });