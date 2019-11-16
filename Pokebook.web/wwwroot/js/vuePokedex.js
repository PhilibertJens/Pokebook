var apiURL = `${server.apiClientSideAddress}/api/`;

var app = new Vue(
    {
        el: '.poke-grid',
        data: {
            loadingMessage: 'Loading pokédex...',
            userId: '',
            listAllPokemonCatches: [],
            listPokemonCatchesToEdit: []
        },
        created: function () {
            var self = this;
            self.userId = document.querySelector('[data-userId]').getAttribute('data-userId');
            self.getAllPokemonCatches();
        },
        methods: {
            getAllPokemonCatches: function (e) {
                self = this;
                fetch(`${apiURL}PokemonCatches/GetMyPokemon/${self.userId}`)
                    .then(res => res.json())
                    .then(function (pokemonList) {
                        self.listAllPokemonCatches = pokemonList;
                        self.listPokemonCatchesToEdit = pokemonList;
                        //console.log(pokemonList[0].pokemon.imgUrl);
                        console.log(pokemonList);
                    })
                    .catch(err => console.error('Fout: ' + err));
            }
        }
    });