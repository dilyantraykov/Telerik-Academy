//Problem 1. Odd or Even
//Write an expression that checks if given integer is odd or even.

var even = 4;
var odd = 3;

console.log(isEven(even));
console.log(isEven(odd));

function isEven(number){
    return number % 2 === 0;
}