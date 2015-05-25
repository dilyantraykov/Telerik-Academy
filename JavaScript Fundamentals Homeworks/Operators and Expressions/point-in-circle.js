// Problem 6. Point in Circle
// Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius

var inside = {x:-5, y:0}, outside = {x:-4, y:-3.5};

console.log(isInside(inside.x, inside.y, 0, 0, 5));
console.log(isInside(outside.x, outside.y, 0, 0, 5));

function isInside(x, y, cx, cy, r) {
    return (x - cx) * (x - cx) + (y - cy) * (y - cy) <= r * r;
}