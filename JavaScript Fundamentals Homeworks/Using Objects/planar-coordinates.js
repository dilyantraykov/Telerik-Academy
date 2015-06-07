// Problem 1. Planar coordinates
// Write functions for working with shapes in standard Planar coordinate system.
// Points are represented by coordinates P(X, Y)
// Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
// Calculate the distance between two points.
// Check if three segment lines can form a triangle.

function Point(x, y) {
    return {
        X: x,
        Y: y
    }
}

function Line(point1, point2) {
    return {
        p1: point1,
        p2: point2,
        length: calucluateDistance(point1, point2)
    }
}

function calucluateDistance(point1, point2) {
    var dx = point1.X - point2.X,
        dy = point1.Y - point2.Y;
    return Math.sqrt(dx * dx + dy * dy);
}

function canFormTriangle(line1, line2, line3) {
    if (line1.length >= line2.length + line3.length ||
        line2.length >= line1.length + line3.length ||
        line3.length >= line2.length + line1.length) {
        return false;
    }
    return true;
}

var p1 = new Point(1, 1),
    p2 = new Point(5, 4),
    p3 = new Point(-2, -3),
    p4 = new Point(0, -5),
    p5 = new Point(-1, -4),
    p6 = new Point(2, 3),
    l1 = new Line(p1, p2),
    l2 = new Line(p3, p4),
    l3 = new Line(p5, p6);

console.log(p1);
console.log(l1);
console.log(calucluateDistance(p1, p2));
console.log(calucluateDistance(p3, p4));
console.log(calucluateDistance(p5, p6));
console.log(canFormTriangle(l1, l2, l3));
