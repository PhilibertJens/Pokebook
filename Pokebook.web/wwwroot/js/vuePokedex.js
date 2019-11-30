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
                        console.log(self.listPokemonCatchesToEdit);
                    })
                    .catch(err => console.error('Fout: ' + err));
            },
            updatePokemonCatchesList: function (e) {
                var self = this;
                self.listPokemonCatchesToEdit = self.getFromLocalStorage("myPokemon");
                var inputValue = self.userValue.replace(/\s/g, '').toLowerCase();
                var param = self.parameterCheck(inputValue).toLowerCase();

                if (param === -1) {
                    var test = inputValue.replace("|", "");
                    self.filterList(test);
                }
                else {
                    var valueArray = inputValue.split("|");
                    self.filterList(valueArray[0]);//filter op naam vb. pidgey
                    self.filterListParam(param);//filter op parameter vb. normal
                }
            },
            getFromLocalStorage: function (storageItem) {
                if (typeof (Storage) !== "undefined") {
                    return JSON.parse(localStorage.getItem(storageItem));
                }
            },
            parameterCheck: function (userValue) {
                var self = this;
                var re = new RegExp(/^(\w+)([|])(\w+)$/);//start met string, gevolgd door | en eindigt op string
                if (re.test(userValue)) return userValue.substring(userValue.indexOf('|') + 1);
                return -1;
            },
            filterList: function (userValue) {
                var self = this;
                for (var i = 0; i < self.listPokemonCatchesToEdit.length; i++) {
                    var name = self.listPokemonCatchesToEdit[i].pokemon.name.toLowerCase();
                    name = name.substring(0, userValue.length);
                    if (name !== userValue) {
                        self.listDeletedPokemonCatches.push(self.listPokemonCatchesToEdit.splice(i, 1));
                        i--;
                    }
                }
            },
            filterListParam: function (param) {
                var self = this;
                for (i = 0; i < self.listPokemonCatchesToEdit.length; i++) {
                    var types = self.listPokemonCatchesToEdit[i].pokemon.pokemonTypes;
                    var ok = self.pokemonHasOneOfTypes(types, param);
                    if (!ok) {
                        self.listDeletedPokemonCatches.push(self.listPokemonCatchesToEdit.splice(i, 1));
                        i--;
                    }
                }
            },
            pokemonHasOneOfTypes: function (types, param) {
                for (var i = 0; i < types.length; i++) {
                    var type = types[i].type.name;//vb. Normal
                    type = type.substring(0, param.length).toLowerCase();
                    if (type === param) return true;//pokemon heeft opgegeven type
                }
                return false;
            }
        }
    });