// Problem 1. Make person
// Write a function for creating persons.
// Each person must have firstname, lastname, age and gender (true is female, false is male)
// Generate an array with ten person with different names, ages and genders

function makePerson(firstName, lastName, age, gender) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: gender
    };
}

var i,
    age,
    firstNames = ['Asen', 'Angel', 'Boris', 'Georgi', 'Marin', 'Ana', 'Eli', 'Elena', 'Gergana', 'Mariika'],
    lastNames = ['Ivanov', 'Dimitrov', 'Petrov', 'Georgiev', 'Nikolov', 'Borisova', 'Gigova', 'Atanasova', 'Ivanova', 'Georgieva'],
    people = [];

for (i = 0; i < 10; i += 1) {
    age = Math.random() * 80 | 0;
    people[i] = makePerson(firstNames[i], lastNames[i], age, i > 4);
}

console.log('Problem 1.\n------------------------------------');

console.log(people);

console.log('------------------------------------\n');

// Problem 2. People of age
// Write a function that checks if an array of person contains only people of age (with age 18 or greater)
// Use only array methods and no regular loops (for, while)

console.log('Problem 2.\n------------------------------------');

console.log('All people in the array are above 18 - ' + people.every(function(person) {
    return person.age >= 18;
}));

console.log('------------------------------------\n');

// Problem 3. Underage people
// Write a function that prints all underaged persons of an array of person
// Use Array#filter and Array#forEach
// Use only array methods and no regular loops (for, while)

console.log('Problem 3.\n------------------------------------');

console.log('Underaged people in the array:\n');
people.filter(function(person) {
    if (person.age < 18)
        console.log(person);
});

console.log('------------------------------------\n');

// Problem 4. Average age of females
// Write a function that calculates the average age of all females, extracted from an array of persons
// Use Array#filter
// Use only array methods and no regular loops (for, while)

console.log('Problem 4.\n------------------------------------');

var females = people.filter(function(person) {
        return person.gender;
    }),
    sum = females.reduce(function(sum, females) {
        sum += females.age;
        return sum;
    }, 0),
    avg = sum / (females.length);

console.log('Average age of females: ' + avg);

console.log('------------------------------------\n');

// Problem 5. Youngest person
// Write a function that finds the youngest male person in a given array of people and prints his full name
// Use only array methods and no regular loops (for, while)
// Use Array#find

console.log('Problem 5.\n------------------------------------');

if (!Array.prototype.find) {
    Array.prototype.find = function(func) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (func(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

var youngster =
    people.sort(function(max, min) {
        return max.age - min.age;
    }).find(function(person) {
        return !person.gender;
    });

console.log('Youngest male person: ' + youngster.firstName + ' ' + youngster.lastName);

console.log('------------------------------------\n');

// Problem 6. Group people
// Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
// Use Array#reduce
// Use only array methods and no regular loops (for, while)

console.log('Problem 6.\n------------------------------------');

var groupedPeople = people.reduce(function(obj, person) {
    if (obj[person.firstName[0]]) {
        obj[person.firstName[0]].push(person);
    } else {
        obj[person.firstName[0]] = [person];
    }
    return obj;
}, {});

console.log(groupedPeople);
