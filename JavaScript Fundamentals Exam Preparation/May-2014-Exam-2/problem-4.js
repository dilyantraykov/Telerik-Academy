function s(n){var n=+n;if(!n)return 1/2;return (4*n-2)*s(n-1)/(n+1);}

var tests = [['7']];

tests.forEach(function(test) {
	console.log(s(test));
});