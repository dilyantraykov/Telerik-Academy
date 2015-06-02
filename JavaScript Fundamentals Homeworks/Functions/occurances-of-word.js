// Problem 3. Occurrences of word
// Write a function that finds all the occurrences of word in a text.
// The search can be case sensitive or case insensitive.
// Use function overloading.

var text = 'Write a function that finds all the occurrences of word in a text.' +
			'The search can be case sensitive or case insensitive.' +
			'Use function overloading.';

console.log(scanTextForWord(text, 'function', 0));
console.log(scanTextForWord(text, 'use', 1));

function scanTextForWord(text, word, sensitivity) {
	var count = 0,
		i = 0,
		len = word.length,
		index = [],
		matches = [],
		sensitive = !!sensitivity; // case-insensitive by default

	if (!sensitive) {
		text = text.toUpperCase();
		word = word.toUpperCase();
	}

	while ((index = text.indexOf(word, i)) > -1) {
         count += 1;
         i = index + len;
    }

    return count;
}