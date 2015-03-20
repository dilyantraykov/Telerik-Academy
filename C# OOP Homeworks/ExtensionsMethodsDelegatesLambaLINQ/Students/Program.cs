/*
Problem 3. First before last

Write a method that from a given array of students finds all students whose first name
is before its last name alphabetically.
Use LINQ query operators.

* 
Problem 4. Age range

Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

* 
Problem 5. Order students

Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
Rewrite the same with LINQ.
*/

using System;
using System.Linq;

class FirstNameBeforeLast
{
    static void Main()
    {
        var students = new[]
        {
            new { FirstName = "Slim", LastName = "Shady", Age = 23 },
            new { FirstName = "Snoop", LastName = "Dog" , Age = 33 },
            new { FirstName = "Doctor", LastName = "Dre", Age = 46 },
        };

        // task 3
        var firstBeforeLast =
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

        // task 4
        var between18And24 =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student;

        // task 5
        var sortedStudents =
            students.OrderByDescending(student => student.FirstName)
                    .ThenByDescending(student => student.LastName);


        Console.WriteLine("Students with first name before last name:");
        foreach (var student in firstBeforeLast)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine();
        Console.WriteLine("Students with age between 18 and 24:");
        foreach (var student in between18And24)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine();
        Console.WriteLine("Students sorted by first and last name:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }
    }
}
