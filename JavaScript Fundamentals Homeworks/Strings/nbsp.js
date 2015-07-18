// Problem 5. nbsp
// Write a function that replaces non breaking white-spaces in a text with &nbsp;

function replaceWhiteSpaces(text) {
    var i, result = '',
        len = text.length;

    for (i = 0; i < len; i += 1) {
        if (text[i] === ' ') {
            result += '&nbsp;';
        } else {
            result += text[i];
        }
    }

    return result;
}

var text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

console.log(replaceWhiteSpaces(text));
