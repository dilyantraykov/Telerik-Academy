// Problem 2. Remove elements
// Write a function that removes all elements with a given value.
// Attach it to the array type.

Array.prototype.remove = function(element) {
    return this.filter(function(item) {
        return item !== element;
    });
};

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'],
    result = arr.remove(1);

console.log(arr);
console.log(result);
