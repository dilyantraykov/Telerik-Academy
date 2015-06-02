// Problem 6. Larger than neighbours
// Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

var numbers = [2, 5, 3, 1, 2, 6, 1, 3, 6, 5];

console.log(isLargerThanNeighbours(5, numbers));

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
