// Problem 8. Number as words
// Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

var numbers = [0, 9, 10, 12, 19, 25, 98, 273, 400, 501, 617, 711, 999];

for (var i = 0; i < numbers.length; i++) {
    console.log(numbers[i] + ' -> ' + numberAsWords(numbers[i]));
}

function numberAsWords(number) {

    var majorDigit = Math.floor(number / 100) % 10,
        middleDigit = Math.floor(number / 10) % 10,
        minorDigit = number % 10,
        result = '';

    if ((number < 0) || (number > 999)) {
        number = 'Invalid number!';
    } else {
        switch (majorDigit) {
            case 1:
                result = 'one hundred ';
                break;
            case 2:
                result = 'two hundred ';
                break;
            case 3:
                result = 'three hundred ';
                break;
            case 4:
                result = 'four hundred ';
                break;
            case 5:
                result = 'five hundred ';
                break;
            case 6:
                result = 'six hundred ';
                break;
            case 7:
                result = 'seven hundred ';
                break;
            case 8:
                result = 'eight hundred ';
                break;
            case 9:
                result = 'nine hundred ';
                break;
            default:
                break;
        }

        if ((majorDigit !== 0) && ((middleDigit !== 0) || (minorDigit !== 0))) {
            result += 'and ';
        }

        switch (middleDigit) {
            case 2:
                result += 'twenty ';
                break;
            case 3:
                result += 'thirty ';
                break;
            case 4:
                result += 'fourty ';
                break;
            case 5:
                result += 'fifty ';
                break;
            case 6:
                result += 'sixty ';
                break;
            case 7:
                result += 'seventy ';
                break;
            case 8:
                result += 'eighty ';
                break;
            case 9:
                result += 'ninety ';
                break;
            default:
                break;
        }

        if (middleDigit !== 1) {
            switch (minorDigit) {
                case 1:
                    result += 'one';
                    break;
                case 2:
                    result += 'two';
                    break;
                case 3:
                    result += 'three';
                    break;
                case 4:
                    result += 'four';
                    break;
                case 5:
                    result += 'five';
                    break;
                case 6:
                    result += 'six';
                    break;
                case 7:
                    result += 'seven';
                    break;
                case 8:
                    result += 'eight';
                    break;
                case 9:
                    result += 'nine';
                    break;
                default:
                    break;
            }
        } else {
            switch (minorDigit) {
                case 0:
                    result += 'ten';
                    break;
                case 1:
                    result += 'evelen';
                    break;
                case 2:
                    result += 'twelve';
                    break;
                case 3:
                    result += 'thirteen';
                    break;
                case 4:
                    result += 'fourteen';
                    break;
                case 5:
                    result += 'fifteen';
                    break;
                case 6:
                    result += 'sixteen';
                    break;
                case 7:
                    result += 'seventeen';
                    break;
                case 8:
                    result += 'eighteen';
                    break;
                case 9:
                    result += 'nineteen';
                    break;
                default:
                    break;
            }
        }

        if (number === 0) {
            result = 'zero';
        }
    }

    return result;
}
