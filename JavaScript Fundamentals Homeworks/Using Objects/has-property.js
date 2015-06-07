// Problem 4. Has property
// Write a function that checks if a given object contains a given property.

function hasProperty(obj, prop) {
    return obj.hasOwnProperty(prop);
}

var student = {
    name: 'Slim Shady',
    profession: 'rapper',
    age: 42,
    grammys: 15
};

console.log(student);
console.log(hasProperty(student, 'age'));
console.log(hasProperty(student, 'grammys'));
console.log(hasProperty(student, 'blah'));
