function solve(params) {
    var i, j, k,
        s = +params[0],
        count = 0;
    // Your solution here
    for (i = 0; i <= s; i += 1) {
        for (j = 0; j <= s; j += 1) {
            for (k = 0; k <= s; k += 1) {
                if ((i * 10 + j * 4 + k * 3) === s) {
                    count += 1;
                }
            }
        }
    }

    console.log(count);
}

var tests = [
	['7'], 
	['10'], 
	['40']
];

tests.forEach(function(test) {
	solve(test);
});