// Problem 5. Selection sort
// Sorting an array means to arrange its elements in increasing order.
// Write a script to sort an array.
// Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

var numbers = [6, 12, 7, 3, 22, -12, 1, 8];

selectionSort(numbers);
console.log(numbers);

function selectionSort(numbers) {
    var i, j, tmp, tmp2,
        len = numbers.length;
    for (i = 0; i < len - 1; i++) {
        tmp = i;
        for (j = i + 1; j < len; j++) {
            if (numbers[j] < numbers[tmp]) {
                tmp = j;
            }
        }
        if (tmp != i) {
            tmp2 = numbers[tmp];
            numbers[tmp] = numbers[i];
            numbers[i] = tmp2;
        }
    }
}
