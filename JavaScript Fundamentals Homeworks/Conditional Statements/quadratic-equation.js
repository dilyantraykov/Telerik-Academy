// Problem 6. Quadratic equation
// Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
// Calculates and prints its real roots.
// Note: Quadratic equations may have 0, 1 or 2 real roots.

console.log(getRoots(2, 5, -3));
console.log(getRoots(-1, 3, 0));
console.log(getRoots(-0.5, 4, -8));
console.log(getRoots(5, 2, 8));

function getRoots(a, b, c) {
    var D = b * b - 4 * a * c,
    	result = [];
    if (D < 0) {
        result.push('no real roots');
    } else if (!D) {
        result.push('x1=x2=' + getRoot(-1, D, b, a));
    } else {
        result.push('x1=' + getRoot(-1, D, b, a), 'x2=' + getRoot(1, D, b, a));
    }
    return result.join('; ');
}

function getRoot(sign, D, b, a) {
    return (-b + Math.sqrt(D) * sign) / (2 * a);
}
