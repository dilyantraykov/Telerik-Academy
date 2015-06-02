// Problem 5. Appearance count
// Write a function that counts how many times given number appears in given array.
// Write a test function to check if the function is working correctly.

var i,
    numbers = [2, 5, 3, 1, 1, 6, 1, 3, 6, 5],
    tests = [
        {
            number: 1,
            expected: 3
        }, {
            number: 2,
            expected: 1
        }, {
            number: 3,
            expected: 2
        }
    ];
len = tests.length;

for (i = 0; i < len; i += 1) {
    console.log(checkAnswer(tests[i].number, tests[i].expected, numbers));
}

function checkAnswer(number, expected, array) {
    return getNumberOfOccurances(number, array) === expected;
}

function getNumberOfOccurances(number, array) {
    var i,
        count = 0,
        len = array.length;

    for (i = 0; i < len; i += 1) {
        if (array[i] === number) {
            count += 1;
        }
    }

    return count;
}
