/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName` and `age` properties
        *   Array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve() {
    return function(students) {
    	_.chain(students)
    		.sortBy(function(student) {
    			var markSum = 0;
    			_.each(student.marks, function(mark) {
    				markSum += mark;
    			})
    			student.averageMark = markSum / student.marks.length
    			return -student.averageMark;
    		})
    		.first(1)
    		.each(function(student) {
    			var fullName = student.firstName + ' ' + student.lastName; 
    			console.log(fullName + ' has an average score of ' + student.averageMark)
    		});
    };
}

module.exports = solve;
