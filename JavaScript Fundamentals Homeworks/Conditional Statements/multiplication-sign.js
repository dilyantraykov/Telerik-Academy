// Problem 2. Multiplication Sign
// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

console.log(getSign(5, 2, 2));
console.log(getSign(-2, -2, 1));
console.log(getSign(-2, 4, 3));
console.log(getSign(0, -2.5, 4));
console.log(getSign(-1, -0.5, -5.1));

function getSign() {
	var negativeNumbers = 0;
	for (var i = 0; i < arguments.length; i+=1) {
		if (arguments[i] < 0) {
			negativeNumbers += 1;
		}
		else if (arguments[i] === 0) {
			return '0';
		}
	}
	return negativeNumbers % 2 ? '-' : '+';
}