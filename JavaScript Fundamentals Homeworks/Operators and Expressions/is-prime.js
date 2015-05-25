// Problem 7. Is prime
// Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

var prime = 23, notPrime = 21;

console.log(isPrime(prime));
console.log(isPrime(notPrime));

function isPrime(number) {
    if (number < 2) {
    	return false;
    }

    for (var divisor = 2; divisor <= Math.sqrt(number); divisor++) {
        if (number % divisor === 0) {
        	return false;
        }
    }

    return true;
}