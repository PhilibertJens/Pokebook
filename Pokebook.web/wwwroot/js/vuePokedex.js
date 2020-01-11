var apiURL = `${server.apiClientSideAddress}/api/`;

var app = new Vue(
    {
        el: '#pokedex',
        data: {
            loadingMessage: 'Loading pokédex...',
            userId: '',
            userValue: '',
            listPokemonCatchesToEdit: [],
            listDeletedPokemonCatches: [],
            sortingTerm: 'recent',
            sortingDirection: 'desc',
            sortTerms: []
        },
        created: function () {
            var self = this;
            self.userId = document.querySelector('[data-userId]').getAttribute('data-userId');
            self.getAllPokemonCatches();
            self.sortTerms = ["recent","Number","HP","Name","CP"];
        },
        methods: {
            getAllPokemonCatches: function (e) {
                var self = this;
                fetch(`${apiURL}PokemonCatches/GetMyPokemon/${self.userId}`)
                    .then(res => res.json())
                    .then(function (pokemonList) {
                        self.listPokemonCatchesToEdit = pokemonList;
                        self.sortList(e);
                        localStorage.setItem("myPokemon", JSON.stringify(self.listPokemonCatchesToEdit));
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
                    var value = inputValue.replace("|", "");
                    self.execute3Filters(value, false);
                }
                else {
                    value = inputValue.split("|")[0];
                    self.execute3Filters(value, false);//check woord vóór paramater
                    self.execute3Filters(param, true);//check paramater
                }
                self.sortList(e);
            },
            execute3Filters: function (value, isParam) {
                var self = this;
                if (!isNaN(value) && value > 0) self.filterListNdex(parseInt(value));
                else if (self.keywordParameterCheck(value)) self.filterListKeywordParam(value);//filter op keyword
                else {
                    if (isParam) self.filterListParam(value);//filter op parameter vb. normal, flyi, b u g
                    else self.filterList(value);//filter op naam vb. pidgey
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
            filterListNdex: function (ndex) {
                var self = this;
                for (var i = 0; i < self.listPokemonCatchesToEdit.length; i++) {
                    var index = self.listPokemonCatchesToEdit[i].pokemon.nDex;
                    if (ndex !== index) {
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
                                "male", "female",
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
                    case "male":
                        return poke.gender === true;//1 is male
                    case "female":
                        return poke.gender === false;//0 is female
                    default:
                        return self.pokemonHasOneOfTypes(types, property);
                }
            },
            sortList: function (e) {
                var self = this;
                console.log("Sorting: " + self.sortingDirection);
                if (self.sortingDirection === 'desc')
                    self.listPokemonCatchesToEdit.sort((a, b) => (a.cp < b.cp) ? 1 : -1);
                else self.listPokemonCatchesToEdit.sort((a, b) => (a.cp > b.cp) ? 1 : -1);
                //console.log(self.sortingTerm);
                //console.log(e.srcElement.innerHTML);
            },
            GetSelectedSortTerm: function (e) {
                var self = this;
                console.log(e);
            }
        }
    });