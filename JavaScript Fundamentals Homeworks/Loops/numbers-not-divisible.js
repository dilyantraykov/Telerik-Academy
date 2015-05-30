// Problem 2. Numbers not divisible
// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var step,
    i = 1,
    n = 36; // change it if you like

step = (n > 1) ? 1 : -1;

console.log(i);
while (i !== n) {
    i += step;
    if (i % 21) {
        console.log(i);
    }
}
