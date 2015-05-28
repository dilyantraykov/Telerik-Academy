// Problem 7. The biggest of five numbers
// Write a script that finds the greatest of given 5 variables.
// Use nested if statements.

console.log(getBiggest(5, 2, 2, 4, 1));
console.log(getBiggest(-2, -22, 1, 0, 0));
console.log(getBiggest(-2, 4, 3, 2, 0));
console.log(getBiggest(0, -2.5, 0, 5, 5));
console.log(getBiggest(-3, -0.5, -1.1, -2, -0.1));

function getBiggest(a, b, c, d, e) {
    if (a >= b) {
        if (a >= c) {
            if (a >= d) {
                if (a >= e) {
                    return a;
                }
            }
        }
    }
    if (b >= a) {
        if (b >= c) {
            if (b >= d) {
                if (b >= e) {
                    return b;
                }
            }
        }
    }
    if (c >= a) {
        if (c >= b) {
            if (c >= d) {
                if (c >= e) {
                    return c;
                }
            }
        }
    }
    if (d >= a) {
        if (d >= b) {
            if (d >= c) {
                if (d >= e) {
                    return d;
                }
            }
        }
    }
    if (e >= a) {
        if (e >= b) {
            if (e >= c) {
                if (e >= d) {
                    return e;
                }
            }
        }
    }
}
