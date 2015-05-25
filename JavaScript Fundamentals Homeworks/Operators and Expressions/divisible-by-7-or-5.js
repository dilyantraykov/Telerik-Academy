// Problem 2. Divisible by 7 and 5
// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var int = 140;

console.log(divisibleBy7And5(int));

function divisibleBy7And5(number) {
	if (number % 7 === 0 && number % 5 === 0) {
		return true;
	}
	return false;
}