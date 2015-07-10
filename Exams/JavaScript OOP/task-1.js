function solve() {
    var module = (function() {

        var catalog,
            bookCatalog,
            mediaCatalog,
            item,
            book,
            media;

        validator = {
            validateIfUndefined: function(val, name) {
                name = name || 'Value';
                if (val === undefined) {
                    throw new Error(name + ' cannot be undefined');
                }
            },
            validateIfObject: function(val, name) {
                name = name || 'Value';
                if (typeof val !== 'object') {
                    throw new Error(name + ' must be an object');
                }
            },
            validateIfNumber: function(val, name) {
                name = name || 'Value';
                if (typeof val !== 'number') {
                    throw new Error(name + ' must be a number');
                }
            },
            validatePositiveNumber: function(val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);
                this.validateIfNumber(val, name);

                if (val <= 0) {
                    throw new Error(name + ' must be positive number');
                }
            },
            validateString: function(val, min, max, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);

                if (typeof val !== 'string') {
                    throw new Error(name + ' must be a string');
                }

                if (val.length < min || max < val.length) {
                    throw new Error(name + ' must be between ' + min +
                        ' and ' + max + ' symbols');
                }
            },
            validateIsbn: function(val, length1, length2, name) {
                this.validateIfUndefined(val, 'Isbn');

                if (val.length !== length1 || length2 !== val.length) {
                    throw new Error('Isbn length must be ' + length1 + ' or ' + length2 + 'symbols.');
                }

                for (var i = 0; i < val.length; i += 1) {
                    if (isNaN(val[i])) {
                        throw new Error('Isbn must contain only digits');
                    }
                }
            },
            validateRating: function(val, name) {
                this.validateIfUndefined(val, 'Isbn');
                this.validateIfNumber(val, name);

                if (val < 1 || val > 5) {
                    throw new Error('Media rating should be between 1 and 5');
                }
            }
        };


        catalog = (function() {
            var nextCatalogId = 0,
                catalog = Object.create({});

            Object.defineProperties(catalog, {
                'init': {
                    value: function(name) {
                        this._id = ++nextCatalogId;
                        this.name = name;
                        this.items = [];
                        return this;
                    }
                },
                'id': {
                    get: function() {
                        return this._id;
                    }
                },
                'items': {
                    get: function() {
                        return this._items;
                    },
                    set: function(value) {
                        this._items = value;
                    }
                },
                'name': {
                    get: function() {
                        return this._name;
                    },
                    set: function(value) {
                        validator.validateString(value, 2, 40, 'Catalog name');
                        this._name = value;
                    }
                },
                'add': {
                    value: function() {
                        var i,
                            len,
                            args;

                        args = Array.prototype.slice.call(arguments[0]);

                        if (args.length === 0) {
                            throw new Error('No arguments passed.');
                        }

                        if (args[0].constructor.name === 'Array') {
                            if (args[0].length === 0) {
                                throw new Error('Empty array passed.');
                            }
                            args = args[0].slice();
                        } else {
                            args = Array.prototype.slice.call(args);
                        }

                        var validItems = [];

                        for (i = 0, len = args.length; i < len; i += 1) {
                            if (args[i]._type === this._type ||
                                args[i]._type === this._type) {
                                validItems.push(args[i]);
                            } else {
                                throw new Error('Is not instance of item');
                            }
                        }

                        Array.prototype.push.apply(this.items, validItems);

                        return this;
                    }
                },
                'find': {
                    value: function(searchId) {
                        var i, len, arrayOfItems = [];

                        var items = this.items;

                        if (typeof(searchId) === 'object') {
                            for (i = 0, len = items.length; i < len; i += 1) {
                                var isMatch = true;
                                for (var key in searchId) {
                                    if (items[i][key] !== searchId[key]) {
                                        isMatch = false;
                                        break;
                                    }
                                }
                                if (isMatch) {
                                    arrayOfItems.push(items[i]);
                                }
                            }
                            return arrayOfItems;
                        } else {
                            for (i = 0, len = items.length; i < len; i += 1) {
                                if (items[i].id === searchId) {
                                    return items[i];
                                }
                            }
                            return null;
                        }
                    }
                }
            });

            return catalog;
        })();

        bookCatalog = (function(parent) {
            var bookCatalog = Object.create(parent);

            Object.defineProperties(bookCatalog, {
                'init': {
                    value: function(name) {
                        parent.init.call(this, name);
                        this._type = 'book';
                        return this;
                    }
                },
                'add': {
                    value: function() {
                        parent.add.call(this, arguments);
                        return this;
                    }
                },
                'getGenres': {
                    value: function() {
                        var genres = [];
                        var items = this.items;
                        for (var i = 0; i < items.length; i += 1) {
                            if (genres.indexOf(items[i].genre.toLowerCase()) < 0) {
                                genres.push(items[i].genre.toLowerCase());
                            }
                        }
                        return genres;
                    }
                }
            });

            return bookCatalog;
        })(catalog);

        mediaCatalog = (function(parent) {
            var mediaCatalog = Object.create(parent);

            Object.defineProperties(mediaCatalog, {
                'init': {
                    value: function(name) {
                        parent.init.call(this, name);
                        this._type = 'media';
                        return this;
                    }
                },
                'add': {
                    value: function() {
                        parent.add.call(this, arguments);
                        return this;
                    }
                },
                'getTop': {
                    value: function(count) {
                        var sortedItems = this.items.slice().
                        sort(function(a, b) {
                            return b.rating - a.rating;
                        }).slice(0, count);

                        //var sortedNameAndIds = [];
                        var sortedNameAndIds = sortedItems.map(function(element) {
                            return {
                                id: element.id,
                                name: element.name
                            };
                        });

                        return sortedNameAndIds;
                    }
                },
                'getSortedByDuration': {
                    value: function() {
                        var sortedItems = this.items.slice()
                        .filter(function(item) {
                            return item._type === 'media';
                        })
                        .sort(function(a, b) {
                            if (b.duration !== a.duration) {
                                return b.duration - a.duration;
                            }
                            return  a.id - b.id;
                        });

                        return sortedItems;
                    }
                }
            });

            return mediaCatalog;
        })(catalog);

        item = (function() {
            var nextItemId = 0,
                item = Object.create({});

            Object.defineProperties(item, {
                'init': {
                    value: function(name, description) {
                        this._id = ++nextItemId;
                        this.name = name;
                        this.description = description;
                        this._type = 'item';
                        return this;
                    }
                },
                'id': {
                    get: function() {
                        return this._id;
                    }
                },
                'name': {
                    get: function() {
                        return this._name;
                    },
                    set: function(value) {
                        validator.validateString(value, 2, 40, 'Item name ');
                        this._name = value;
                    }
                },
                'description': {
                    get: function() {
                        return this._description;
                    },
                    set: function(value) {
                        this._description = value;
                    }
                }
            });

            return item;
        })();

        book = (function(parent) {
            var book = Object.create(parent);

            Object.defineProperties(book, {
                'init': {
                    value: function(name, description, isbn, genre) {
                        parent.init.call(this, name, description);
                        this._type = 'book';
                        this.isbn = isbn;
                        this.genre = genre;
                        return this;
                    }
                },
                'genre': {
                    get: function() {
                        return this._genre;
                    },
                    set: function(value) {
                        validator.validateString(value, 2, 20, 'Book genre ');
                        this._genre = value;
                    }
                },
                'isbn': {
                    get: function() {
                        return this._isbn;
                    },
                    set: function(value) {
                        this._isbn = value;
                    }
                }
            });

            return book;
        })(item);

        media = (function(parent) {
            var media = Object.create(parent);

            Object.defineProperties(media, {
                'init': {
                    value: function(name, description, duration, rating) {
                        parent.init.call(this, name, description);
                        this.duration = duration;
                        this.rating = rating;
                        this._type = 'media';
                        return this;
                    }
                },
                'duration': {
                    get: function() {
                        return this._duration;
                    },
                    set: function(value) {
                        validator.validatePositiveNumber(value, 'Media rating ');
                        this._duration = value;
                    }
                },
                'rating': {
                    get: function() {
                        return this._rating;
                    },
                    set: function(value) {
                        validator.validateRating(value, 'Media rating');
                        this._rating = value;
                    }
                }
            });

            return media;
        })(item);

        return {
            getBook: function(name, isbn, genre, description) {
                return Object.create(book).init(name, description, isbn, genre);
            },
            getMedia: function(name, rating, duration, description) {
                return Object.create(media).init(name, description, duration, rating);
            },
            getBookCatalog: function(name) {
                return Object.create(bookCatalog).init(name);
            },
            getMediaCatalog: function(name) {
                return Object.create(mediaCatalog).init(name);
            }
        };
    })();

    return module;
}
var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
var book3 = module.getBook('JavaScript: The Good Parts', '0123456789', 'SS', 'A good book about JS');
var book4 = module.getBook('JavaScript: The Good Parts', '0123456789', 'CC', 'A good book about JS');
var books = [book1, book2, book3, book4];
catalog.add(books);

var catalog2 = module.getMediaCatalog('John\'s catalog');

var media1 = module.getMedia('The secrets of the JavaScript Ninja', 3, 12, 'A media about JavaScript');
var media2 = module.getMedia('JavaScript: The Good Parts', 2, 15, 'A good media about JS');
var media3 = module.getMedia('JavaScript: The Good Parts', 2, 1, 'A good media about JS');
var media4 = module.getMedia('JavaScript: The Good Parts', 4, 3, 'A good media about JS');
var medias = [media1, media2, media3, media4];
catalog2.add(medias);

console.log(catalog);
console.log(catalog2);

console.log(catalog.find(book1.id));
//returns book1

console.log(catalog.find({
    id: book2.id,
    genre: 'blah'
}));

console.log(catalog.getGenres());
console.log(catalog2.getSortedByDuration());


console.log(catalog2.getTop(3));
//returns book2
/*
console.log(catalog.search('js'));
// returns book2

console.log(catalog.search('javascript'));
//returns book1 and book2

console.log(catalog.search('Te sa zeleni'))
    //returns []
*/
