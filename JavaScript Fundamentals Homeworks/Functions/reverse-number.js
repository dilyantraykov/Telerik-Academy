// Problem 2. Reverse number
// Write a function that reverses the digits of given decimal number.

console.log(reverseNumber(256));
console.log(reverseNumber(123.45));

function reverseNumber(number) {
    return +reverse(number.toString());
}

function reverse(str) {
    var i,
        result = '';
    for (i = str.length - 1; i >= 0; i -= 1)
        result += str[i];
    return result;
}
