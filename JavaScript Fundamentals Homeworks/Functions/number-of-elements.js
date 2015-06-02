// Problem 4. Number of elements
// Write a function to count the number of div elements on the web page

// Note: You need to open number-of-elements.html and see the console log

console.log(countDivs());

function countDivs() {
    return document.getElementsByTagName('div').length;
}
