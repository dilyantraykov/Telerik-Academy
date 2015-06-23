/* Task Description */
/*
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
    var Person = (function() {
        var _firstname;
        var _lastame;
        var _age;

        function Person(fname, lname, age) {
            this.firstname = fname;
        	this.lastname = lname;
        	this.age = age;
        }

        Person.prototype.introduce = function() {
        	return 'Hello! My name is '+ this.fullname + ' and I am ' + this.age + '-years-old';
        };

        Object.defineProperty(Person.prototype, 'firstname', {
            get: function() {
                return this._firstname;
            },
            set: function(fname) {
                if (typeof(fname) != 'string' ||
                    fname.length < 3 || fname.length > 20) {
                    throw new Error();
                }
                this._firstname = fname;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get: function() {
                return this._lastname;
            },
            set: function(lname) {
                if (typeof(lname) != 'string' ||
                    lname.length < 3 || lname.length > 20) {
                    throw new Error();
                }
                this._lastname = lname;
            }
        });

        Object.defineProperty(Person.prototype, 'age', {
            get: function() {
                return this._age;
            },
            set: function(age) {
                if (age < 3 || age > 20) {
                    throw new Error();
                }
                this._age = age;
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function() {
                return this.firstname + ' ' + this.lastname;
            },
            set: function(name) {
                var fullname = name.split(' ');
                this.firstname = fullname[0];
                this.lastname = fullname[1];
            }
        });

        return Person;
    }());
    return Person;
}
module.exports = solve;
