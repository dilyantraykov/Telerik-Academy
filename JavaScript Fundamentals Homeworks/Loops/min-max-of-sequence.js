// Problem 3. Min/Max of sequence
// Write a script that finds the max and min number from a sequence of numbers.

var i,
    numbers = [12, 23, 5, 4, 16, 21, -5, -12, 0],
    len = numbers.length,
    min = numbers[0],
    max = numbers[0];

for (i = 1; i < len; i += 1) {
    if (numbers[i] > max) {
        max = numbers[i];
    }
    if (numbers[i] < min) {
        min = numbers[i];
    }
}

console.log('Min: ' + min);
console.log('Max: ' + max);
