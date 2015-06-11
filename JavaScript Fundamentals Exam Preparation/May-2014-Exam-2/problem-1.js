function solve(params) {
    var i, j, k,
        s = params[0],
        c1 = params[1],
        c2 = params[2],
        c3 = params[3],
        answer = 0;

    for (i = 0; i <= s / c1; i += 1) {
        for (j = 0; j <= s / c2; j += 1) {
            for (k = 0; k <= s / c3; k += 1) {
            	sum = i * c1 + j * c2 + k * c3;
            	if (sum <= s && sum > answer) {
            		answer = sum;
            	}
            }
        }
    }

    console.log(answer);
}

var tests = [
    ['110', '13', '15', '17'],
    ['20', '11', '200', '300'],
    ['110', '19', '29', '39']
];

tests.forEach(function(test) {
    solve(test);
});
