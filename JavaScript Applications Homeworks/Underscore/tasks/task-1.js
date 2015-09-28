/* 
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName` and `lastName` properties
*   **Finds** all students whose `firstName` is before their `lastName` alphabetically
*   Then **sorts** them in descending order by fullname
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   Then **prints** the fullname of founded students to the console
*   **Use underscore.js for all operations**
*/

function solve() {
    return function(students) {
        _.chain(students)
            .filter(function(student) {
                var firstName = student.firstName;
                var lastName = student.lastName;
                return firstName < lastName;
            }).sortBy(function(student) {
                var firstName = student.firstName;
                var lastName = student.lastName;
                student.fullName = firstName + ' ' + lastName;
                return student.fullName;
            }).reverse().each(function(student) {
                console.log(student.fullName);
            });
    };
}

module.exports = solve;
