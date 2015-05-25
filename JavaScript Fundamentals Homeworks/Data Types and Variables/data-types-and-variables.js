// Problem 1. JavaScript literals
// Assign all the possible JavaScript literals to different variables.

var int = 254;
var float = 25.4;
var arr = [1, 2, 3];
var object = {course: 'JS', part: 1};
var func = function(){return;};

// Problem 2. Quoted text
// Create a string variable with quoted text in it.
// For example: `'How you doin'?', Joey said'.

var string = "'How you doin'?', Joey said";
var string2 = '\'How you doin\'?\', Joey said';

// Problem 4. Typeof null
// Create null, undefined variables and try typeof on them.

var nullVar = null;
var undefinedVar; // undefined

// Problem 3. Typeof variables
// Try typeof on all variables you created.

var variables = [int, float, arr, object, func, nullVar, undefinedVar, string, string2];

for(var variable in variables){
    console.log(getType(variables[variable]));
}

function getType(obj){
    var result = obj;
    result += ' is of type ' + typeof(obj);
    return result;
}