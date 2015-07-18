/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {

    function isValidTitle(title) {
        if (title === null || typeof title !== 'string') {
            return false;
        }

        if (title.length === 0 || title.trim() == '' || title.length != title.trim().length || /[\s]{2,}/.test(title)) {
            return false;
        }

        return true;
    }

    function areValidPresentations(presentations) {
        if (presentations === null || !Array.isArray(presentations) || presentations.length === 0) {
            return false;
        }

        for (var ind = 0, len = presentations.length; ind < len; ind += 1) {
            if (!isValidTitle(presentations[ind])) {
                return false;
            }
        }

        return true;
    }

    function isValidName(name) {
        return /^[A-Z][a-z]*$/.test(name);
    }

    function isValidId(id, max) {
        if (id < 1 || id > max) {
            return false;
        }

        return true;
    }

    var Course = {
        init: function(title, presentations) {
            if (!isValidTitle(title)) {
                throw new Error('Invalid title!');
            }
            this.title = title;
            if (!areValidPresentations(presentations)) {
                throw new Error('There should be at least one presentation in the course.');
            }
            this.presentations = presentations.slice();
            this.students = [];
            this.studentId = 1;

            return this;
        },
        addStudent: function(name) {
            var fname = name.split(' ')[0],
                lname = name.split(' ')[1];
            if (!isValidName(fname) || !isValidName(lname) ||
                name.split(' ')[2] !== undefined) {
                throw new Error('Invalid student name!');
            }
            this.students.push({
                firstname: fname,
                lastname: lname,
                id: this.studentId
            });

            return this.studentId++;
        },
        getAllStudents: function() {
            return this.students.slice();
        },
        submitHomework: function(studentID, homeworkID) {
            if (!isValidId(homeworkID, this.presentations.length)) {
                throw new Error('Invalid homework ID');
            }

            if (!isValidId(studentID, this.students.length)) {
                throw new Error('Invalid student ID');
            }

            return this;
        },
        pushExamResults: function(results) {},
        getTopStudents: function() {}
    };

    return Course;
}

module.exports = solve;
