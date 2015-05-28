// Problem 4. Sort 3 numbers
// Sort 3 real values in descending order.
// Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.

console.log(sortThreeNumbers(5, 1, 2));
console.log(sortThreeNumbers(-2, -2, 1));
console.log(sortThreeNumbers(-2, 4, 3));
console.log(sortThreeNumbers(0, -2.5, 5));
console.log(sortThreeNumbers(-1.1, -0.5, -0.1));
console.log(sortThreeNumbers(10, 20, 30));
console.log(sortThreeNumbers(1, 1, 1));

function sortThreeNumbers(a, b, c) {
    var sorted = [];
    if (a >= b) {
        if (b >= c) {
            sorted.push(a, b, c);
        } else if (c > a) {
            sorted.push(c, a, b);
        } else {
            sorted.push(a, c, b);
        }
    } else {
        if (b >= c) {
            if (c >= a) {
                sorted.push(b, c, a);
            } else {
                sorted.push(b, a, c);
            }
        } else {
            sorted.push(c, b, a);
        }
    }
    return sorted.join(' ');
}
