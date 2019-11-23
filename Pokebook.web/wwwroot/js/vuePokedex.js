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
                /*als er items uit de list gewist worden gebeurt dit ook bij alle variabelen die naar deze list verwijzen vb. listAllPokemonCatches.
                2 oplossingen:
                - bij het weghalen van letters uit de input list wordt de volledige list terug opnieuw opgehaald en gefilterd --> veel dataverbruik maar eenvoudig
                - de volledige list opslaan in local storage en ophalen wanneer er letters verwijderd worden --> minder dataverbruik maar moeilijker
                eerst de eerste methode testen en nadien de tweede eens proberen.*/
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
            },
            getFromLocalStorage: function (storageItem) {
                if (typeof (Storage) !== "undefined") {
                    return JSON.parse(localStorage.getItem(storageItem));
                }
            }
        }
    });