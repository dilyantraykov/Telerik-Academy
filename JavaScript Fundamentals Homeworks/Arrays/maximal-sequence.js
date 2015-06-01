// Problem 3. Maximal sequence
// Write a script that finds the maximal sequence of equal elements in an array.

var maxCountElement,
    arr = [],
    count = 1,
    maxCount = 1,
    numbers = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    len = numbers.length;

for (i = 1; i < len; i += 1) {
    if (numbers[i] === numbers[i - 1]) {
        count++;
    } else {
        count = 1;
    }
    if (count > maxCount) {
        maxCount = count;
        maxCountElement = numbers[i];
    }
}

for (i = 0; i < maxCount; i += 1) {
    arr.push(maxCountElement);
}

console.log(arr);
