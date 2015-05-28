// Problem 3. The biggest of Three
// Write a script that finds the biggest of three numbers.
// Use nested if statements.

console.log(getBiggest(5, 2, 2));
console.log(getBiggest(-2, -2, 1));
console.log(getBiggest(-2, 4, 3));
console.log(getBiggest(0, -2.5, 5));
console.log(getBiggest(-0.1, -0.5, -0.1));

function getBiggest() {
    var max = -Number.MAX_VALUE;
    for (var i = 0; i < arguments.length; i += 1) {
        if (arguments[i] > max) {
            max = arguments[i];
        }
    }
    return max;
}
