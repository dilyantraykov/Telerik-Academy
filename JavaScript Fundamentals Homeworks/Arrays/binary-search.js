// Problem 7. Binary search
// Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

var numbers = [1, 4, 6, 7, 12, 13, 15, 18, 19, 20, 22, 24],
	findIndexOf = 7;

console.log(findIndex(numbers, findIndexOf));

function findIndex(numbers, target) {
    return binarySearch(numbers, target, 0, numbers.length - 1);
}

function binarySearch(numbers, target, start, end) {
    var middle = Math.floor((start + end) / 2),
        value = numbers[middle];

    if (start > end) {
        return -1;
    }
    if (value > target) {
        return binarySearch(numbers, target, start, middle - 1);
    }
    if (value < target) {
        return binarySearch(numbers, target, middle + 1, end);
    }
    return middle;
}
