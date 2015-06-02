// Problem 7. First larger than neighbours
// Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
// Use the function from the previous exercise.

var numbers = [2, 1, 6, 1, 3, 1, 1, 3, 6, 5];

console.log(getFirstLargerThanNeighbours(numbers));

function getFirstLargerThanNeighbours(array) {
    var i,
        len = array.length;

    for (i = 0; i < len; i += 1) {
        if (isLargerThanNeighbours(i, array)) {
            return i;
        }
    }

    return -1;
}

function isLargerThanNeighbours(index, array) {
    var i,
        len = array.length;

    if (index < 1 || index > len - 2) {
        return false;
    }
    if (array[index] > array[index - 1] &&
        array[index] > array[index + 1]) {
        return true;
    } else {
        return false;
    }
}
