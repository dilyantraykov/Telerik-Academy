// Problem 1. Exchange if greater
// Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
// As a result print the values a and b, separated by a space.

console.log(swapIfGreaterAndPrint(5, 2));
console.log(swapIfGreaterAndPrint(3, 4));
console.log(swapIfGreaterAndPrint(5.5, 4.5));

function swapIfGreaterAndPrint(a, b) {
    if (a > b) {
        a += b;
        b = a - b;
        a = a - b;
    }
    return a + ' ' + b;
}
