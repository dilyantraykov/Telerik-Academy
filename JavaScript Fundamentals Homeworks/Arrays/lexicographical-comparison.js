// Problem 2. Lexicographically comparison
// Write a script that compares two char arrays lexicographically (letter by letter).

var i,
    str1 = "Tomatoes",
    str2 = "tOmatoes",
    len = (str1 > str2) ? str2.length : str1.length;

for (i = 0; i < len; i += 1) {
    console.log((str1[i] > str2[i]) ? str1[i] : str2[i]);
}
