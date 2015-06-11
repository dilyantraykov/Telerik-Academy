function solve(args) {
    var r = args[0].split(' ')[0],
        c = args[0].split(' ')[1],
        i = 0, 
        currentRow = 0, 
        currentCol = 0, 
        result = 0,
        matrix = [];

    args = args.slice(1);

    args.forEach(function(row) {
        matrix[i] = row.split(' ');
        i += 1;
    });

    while (1) {
        if (currentRow < 0 || currentRow >= r ||
            currentCol < 0 || currentCol >= c) {
            return 'successed with ' + result;
        }

        if (matrix[currentRow][currentCol] === 'x') {
            return 'failed at (' + currentRow + ', ' + currentCol + ')';
        }

        currentCell = matrix[currentRow][currentCol];
        matrix[currentRow][currentCol] = 'x';

        result += (1 << currentRow) + currentCol;

        switch (currentCell[0]) {
            case 'd':
                currentRow += 1;
                break;
            case 'u':
                currentRow -= 1;
                break;
        }

        switch (currentCell[1]) {
            case 'r':
                currentCol += 1;
                break;
            case 'l':
                currentCol -= 1;
                break;
        }
    }
}

var tests = [
[
'3 5',
'dr dl dr ur ul',
'dr dr ul ur ur',
'dl dr ur dl ur'
],
[
'3 5',
'dr dl dl ur ul',
'dr dr ul ul ur',
'dl dr ur dl ur'
]
];

tests.forEach(function(test) {
    console.log(solve(test));
});