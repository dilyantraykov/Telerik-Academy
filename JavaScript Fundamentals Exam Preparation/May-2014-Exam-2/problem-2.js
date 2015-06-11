function solve(args) {
	var R = args[0].split(' ')[0];
	var C = args[0].split(' ')[1];

	var matrix = [];
	var currentRow = R - 1;
	var currentCol = C - 1;
	var sum = 0;
	var jumps = 0;

	for (var i = 0; i < R; i += 1) {
		matrix.push(args[i + 1].split(''));
	}

	while(1) {
		if (currentRow < 0 || currentRow >= R ||
			currentCol < 0 || currentCol >= C) {
			return "Go go Horsy! Collected " + sum + " weeds";
		}

		if (matrix[currentRow][currentCol] === 'x') {
			return 'Sadly the horse is doomed in ' + jumps + ' jumps';
		}

		sum += (1 << currentRow) + (-1 * currentCol);
		var currentCell = matrix[currentRow][currentCol];
		matrix[currentRow][currentCol] = 'x';

		switch(currentCell) {
			case '1':
				currentRow -= 2;
				currentCol += 1;
				break;
			case '2':
				currentRow -= 1;
				currentCol += 2;
				break;
			case '3':
				currentRow += 1;
				currentCol += 2;
				break;
			case '4':
				currentRow += 2;
				currentCol += 1;
				break;
			case '5':
				currentRow += 2;
				currentCol -= 1;
				break;
			case '6':
				currentRow += 1;
				currentCol -= 2;
				break;
			case '7':
				currentRow -= 1;
				currentCol -= 2;
				break;
			case '8':
				currentRow -= 2;
				currentCol -= 1;
				break;
		}

		jumps += 1;
	}
}

var tests = [
[
 '3 5',
 '54561',
 '43328',
 '52388',
],
[
 '3 5',
 '54361',
 '43326',
 '52188',
]
];

tests.forEach(function(test) {
	console.log(solve(test));
});