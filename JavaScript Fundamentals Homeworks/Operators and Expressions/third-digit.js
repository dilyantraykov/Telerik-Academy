// Problem 4. Third digit
// Write an expression that checks for given integer if its third digit (right-to-left) is 7.

var int = 701;

console.log(thirdDigitIs7(int));

function thirdDigitIs7(number) {
	if ((((number / 100) | 0) % 10) === 7) {
		return true;
	}
	return false;
}