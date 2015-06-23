function findPrimeNumbersInRange(from, to) {
	var i, divisor,
		maxDivisor,
		from = +from,
		to = +to,
		primeNumbers = [];

	if (typeof(from) === undefined || typeof(to) === undefined ||
			isNaN(from) || isNaN(to)) {
		throw new Error();
	}

	for (i = from; i <= to; i += 1) {
		var isPrime = true;
		if (i < 2) {
			isPrime = false;
		}
		for (divisor = 2, maxDivisor = Math.sqrt(i); divisor <= maxDivisor; divisor += 1) {
			if (i % divisor === 0) {
				isPrime = false;
				break;
			}
		}
		if (isPrime) {
			primeNumbers.push(i);
		}
	}

	return primeNumbers;
}

module.exports = findPrimeNumbersInRange;