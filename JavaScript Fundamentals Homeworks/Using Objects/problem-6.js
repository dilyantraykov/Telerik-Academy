// Problem 6.
// Write a function that groups an array of people by age, first or last name.
// The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
// Use function overloading (i.e. just one function)

function group(people, property) {
    var result = {};

    for (person of people) {
        var groupProperty = person[property];

        if (!result.hasOwnProperty(groupProperty)) {
            result[groupProperty] = [];
        }
        result[groupProperty].push(person);
    }

    return result;
}

var people = [{
    firstname: 'Gosho',
    lastname: 'Petrov',
    age: 32
}, {
    firstname: 'Bay',
    lastname: 'Ivan',
    age: 81
}, {
    firstname: 'Jo',
    lastname: 'Burziq',
    age: 44
}, {
    firstname: 'Gosho',
    lastname: 'Ivanov',
    age: 48
}, {
    firstname: 'Strahil',
    lastname: 'Ivanov',
    age: 32
}, {
    firstname: 'Baby',
    lastname: 'Born',
    age: 1
}];

console.log('----------------Grouped by age----------------\n');

console.log(group(people, 'age'));

console.log('\n----------------Grouped by firstname----------------\n');

console.log(group(people, 'firstname'));

console.log('\n----------------Grouped by lastname----------------\n');

console.log(group(people, 'lastname'));
