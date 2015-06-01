// Problem 6. Most frequent number
// Write a script that finds the most frequent number in an array.

var i,
    numbers = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    len = numbers.length,
    dict = {},
    maxNum = numbers[0],
    maxCount = 1;

for (i = 0; i < len; i++) {
    if (dict[numbers[i]] == null) {
        dict[numbers[i]] = 1;
    } else {
        dict[numbers[i]]++;
    }
    if (dict[numbers[i]] > maxCount) {
        maxNum = numbers[i];
        maxCount = dict[numbers[i]];
    }
}

console.log(maxNum + '(' + maxCount + ')');
