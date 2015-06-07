// Problem 5. Youngest person
// Write a function that finds the youngest person in a given array of people and prints his/hers full name
// Each person has properties firstname, lastname and age.

function findYoungest(people) {
    var minAge,
        youngestPerson;
    for (person of people) {
        if (minAge == null) {
            minAge = person.age;
        }
        if (youngestPerson == null) {
            youngestPerson = person;
        }
        if (person.age < minAge) {
            minAge = person.age;
            youngestPerson = person;
        }
    }
    console.log(youngestPerson.firstname + ' ' + youngestPerson.lastname);
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
    firstname: 'Baby',
    lastname: 'Born',
    age: 1
}];

findYoungest(people);
