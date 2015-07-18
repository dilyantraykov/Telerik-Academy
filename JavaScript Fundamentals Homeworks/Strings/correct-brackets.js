// Problem 2. Correct brackets
// Write a JavaScript function to check if in a given expression the brackets are put correctly.

function correctBrackets(exp) {
    var i,
        result = 0,
        len = exp.length;

    for (i = 0; i < exp.length; i++) {
        if (exp[i] === '(') {
            result++;
        } else if (exp[i] === ')') {
            result--;
        }

        if (result < 0) {
            return false;
        }
    }

    return result ? false : true;
}

console.log(correctBrackets('((a+b)/5-d)'));
console.log(correctBrackets(')(a+b))'));
