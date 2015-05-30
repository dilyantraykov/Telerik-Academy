// Problem 1. Numbers
// Write a script that prints all the numbers from 1 to N.

var step,
    i = 1,
    n = -10; // change it if you like

step = (n > 1) ? 1 : -1;

console.log(i);
while (i !== n) {
    i += step;
    console.log(i);
}
