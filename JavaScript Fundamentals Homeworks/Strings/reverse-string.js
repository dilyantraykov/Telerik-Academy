// Problem 1. Reverse string
// Write a JavaScript function that reverses a string and returns it.

function reverseString(str) {
    var i,
        len = str.length,
        result = '';

    for (i = 0; i < len; i += 1) {
    	result += str[len - 1 - i];
    }

    return result;
}

console.log(reverseString('sample'));
