// Problem 3. Sub-string in text
// Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

function findOccurances(substr, text) {
    var i,
        len = text.length,
        count = 0,
        position = 0;

    while (text.indexOf(substr, position) !== -1) {
        count += 1;
        position = text.indexOf(substr, position) + 1;
    }

    return count;
}

var text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
console.log(findOccurances('in', text));
