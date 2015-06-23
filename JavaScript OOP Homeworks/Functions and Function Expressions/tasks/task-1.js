function sum(numbers) {
    if (numbers == undefined) {
        throw new Error();
    }

    var sum = 0,
        i,
        len = numbers.length;

    if (len === 0) {
        return null;
    }

    for (i = 0; i < len; i += 1) {
        if (isNaN(+numbers[i])) {
            throw new Error();
        }
        sum += +numbers[i];
    }

    return sum;
}

module.exports = sum;
