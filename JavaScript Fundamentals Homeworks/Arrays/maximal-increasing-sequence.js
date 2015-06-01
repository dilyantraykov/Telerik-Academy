// Problem 4. Maximal increasing sequence
// Write a script that finds the maximal increasing sequence in an array.

var maxCountElement,
    arr = [],
    count = 1,
    maxCount = 1,
    numbers = [3, 2, 3, 4, 12, 13, 14, 15, 5, 6],
    len = numbers.length;

for (i = 1; i < len; i += 1) {
    if (numbers[i] === numbers[i - 1] + 1) {
        count++;
    } else {
        count = 1;
    }
    if (count > maxCount) {
        maxCount = count;
        maxCountElement = numbers[i];
    }
}

for (i = maxCount - 1; i >= 0; i -= 1) {
    arr.push(maxCountElement - i);
}

console.log(arr);
