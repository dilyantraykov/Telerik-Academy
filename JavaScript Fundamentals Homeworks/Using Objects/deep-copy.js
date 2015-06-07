// Problem 3. Deep copy
// Write a function that makes a deep copy of an object.
// The function should work for both primitive and reference types.

function clone(obj) {
    if (null == obj || 'object' != typeof obj) {
        return obj;
    }

    var copy = obj.constructor();

    for (var attr in obj) {
        if (obj.hasOwnProperty(attr)) {
            copy[attr] = obj[attr];
        }
    }

    return copy;
}

console.log(clone(5));
console.log(clone({
    name: 'Slim Shady',
    profession: 'rapper'
}));
