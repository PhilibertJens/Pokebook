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
                
                if (param === '-1') {
                    var test = inputValue.replace("|", "");
                    if (self.keywordParameterCheck(test)) self.filterListKeywordParam(test);//filter op keyword
                    else self.filterList(test);//filter op naam vb. pidgey
                }
                else {
                    var valueArray = inputValue.split("|");
                    //check woord vóór paramater
                    if (self.keywordParameterCheck(valueArray[0])) self.filterListKeywordParam(valueArray[0]);//filter op keyword
                    else self.filterList(valueArray[0]);//filter op naam vb. pidgey
                    //check paramater
                    if (self.keywordParameterCheck(param)) self.filterListKeywordParam(param);//filter op keyword
                    else self.filterListParam(param);//filter op parameter vb. normal, flyi, b u g
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
                var reShinyAlolan = new RegExp(/^(\w+)([|])(\w+)([-])(\w+)$/);//start met string, gevolgd door | , gevolgd door string, gevolgd door - en eindigt op string
                if (reShinyAlolan.test(userValue)) return userValue.substring(userValue.indexOf('|') + 1);
                
                return '-1';
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
            filterListKeywordParam: function (param) {
                var self = this;
                for (var i = 0; i < self.listPokemonCatchesToEdit.length; i++) {
                    var poke = self.listPokemonCatchesToEdit[i];
                    if (!self.switchKeyword(param, poke)) {
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
            },
            keywordParameterCheck: function (userValue) {
                var self = this;
                var keywords = ["legendary", "mythical", "shiny", "alolan", "shiny-alolan",
                                "normal", "fighting", "flying", "poison", "ground", "rock",
                                "bug", "ghost", "steel", "fire", "water", "grass", "electric",
                                "psychic", "ice", "dragon", "dark", "fairy"];
                for (var i = 0; i < keywords.length; i++) {
                    if (userValue === keywords[i]) return true;
                }
                return false;
            },
            switchKeyword: function (property, poke) {
                var self = this;
                var types = poke.pokemon.pokemonTypes;
                switch (property) {
                    case "legendary":
                        return poke.pokemon.isLegendary;
                    case "mythical":
                        return poke.pokemon.isMythical;
                    case "shiny":
                        return poke.isShiny;
                    case "alolan":
                        return poke.isAlolan;
                    case "shiny-alolan":
                        return poke.isShiny && poke.isAlolan;
                    default:
                        return self.pokemonHasOneOfTypes(types, property);
                }
            }
        }
    });