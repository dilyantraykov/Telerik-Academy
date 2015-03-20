/*
* Problem 9. Student groups

Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.

* Problem 10. Student groups extensions

Implement the previous using the same query expressed with extension methods.

* Problem 11. Extract students by email

Extract all students that have email in abv.bg.
Use string methods and LINQ.

* Problem 12. Extract students by phone

Extract all students with phones in Sofia.
Use LINQ.

* Problem 13. Extract students by marks

Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
Use LINQ.

* Problem 14. Extract students with two marks

Write down a similar program that extracts the students with exactly two marks "2".
Use extension methods.

* Problem 15. Extract marks

Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

* Problem 18. Grouped by GroupNumber

Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
Use LINQ.

* Problem 19. Grouped by GroupName extensions

Rewrite the previous using extension methods.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public uint FN { get; set; }

    public string Tel { get; set; }

    public string Email { get; set; }

    public List<uint> Marks { get; set; }

    public byte GroupNumber { get; set; }

    public Student(string firstName = null, string lastName = null,
                    uint fn = 0, string tel = null, string email = null,
                    List<uint> marks = null, byte gn = 0)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.FN = fn;
        this.Tel = tel;
        this.Email = email;
        this.Marks = new List<uint>();
        this.Marks = marks.Select(item => item).ToList();
        this.GroupNumber = gn;
    }
}

class TestStudents
{

    static void Main()
    {
        var students = new List<Student>();

        students.Add(new Student("Slim", "Shady", 1011106, "+359899123456",
                    "test@abv.bg", new List<uint>() {5, 6}, 2));

        students.Add(new Student("Doctor", "Dre", 1011208, "+359899127891",
                    "test@gmail.com", new List<uint>() { 4, 5, 3 }, 2));

        students.Add(new Student("Snoop", "Dog", 1011209, "+359899127833",
                    "test2@abv.bg", new List<uint>() { 4, 4, 6 }, 1));

        students.Add(new Student("T", "Pain", 1011206, "+35928884532",
                    "test3@abv.bg", new List<uint>() { 4, 4 }, 1));

        // task 9
        var studentsInGroup2 =
            from student in students
            where student.GroupNumber == 2
            orderby student.FirstName
            select student;

        // task 10
        // var studentsInGroup2 = students.Where(x => x.GroupNumber == 2).OrderBy(student => student.FirstName);

        Console.WriteLine("Students in group number 2:");
        foreach (var student in studentsInGroup2)
        {
            Console.WriteLine("* " + student.FirstName + " " + student.LastName);
        }

        Console.WriteLine();
        Console.WriteLine(new string('-', 40));

        // task 11
        var studentsWithAbv = students.Where(student => student.Email.Contains("abv.bg"));

        Console.WriteLine("Students with email in abv.bg:");
        foreach (var student in studentsWithAbv)
        {
            Console.WriteLine("* " + student.FirstName + " " + student.LastName);
        }

        Console.WriteLine();
        Console.WriteLine(new string('-', 40));

        // task 12
        var studentsWithPhoneInSofia = students.Where(student => student.Tel.StartsWith("02")
                                                    || student.Tel.StartsWith("+3592"));

        Console.WriteLine("Students with phones in Sofia:");
        foreach (var student in studentsWithPhoneInSofia)
        {
            Console.WriteLine("* " + student.FirstName + " " + student.LastName);
        }

        Console.WriteLine();
        Console.WriteLine(new string('-', 40));

        // task 13
        var studentsWithExcellent =
            from student in students
            where student.Marks.Any(mark => mark == 6)
            select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Marks = string.Join(", ", student.Marks)
                };

        Console.WriteLine("Students with excellent mark:");
        foreach (var student in studentsWithExcellent)
        {
            Console.WriteLine("* " + student);
        }


        Console.WriteLine();
        Console.WriteLine(new string('-', 40));

        // task 14
        var studentsWithExactly2Marks = students.Where(student => student.Marks.Count == 2);

        Console.WriteLine("Students with exactly two marks:");
        foreach (var student in studentsWithExactly2Marks)
        {
            Console.WriteLine("* " + student.FirstName + " " + student.LastName);
        }

        Console.WriteLine();
        Console.WriteLine(new string('-', 40));

        // task 15
        var studentsFrom2006 = students.Where(student => student.FN.ToString()[5] == '0'
                                                        && student.FN.ToString()[6] == '6');

        Console.WriteLine("The marks of students from 2006:");
        foreach (var student in studentsFrom2006)
        {
            Console.WriteLine("* " + string.Join(", ", student.Marks));
        }

        Console.WriteLine();
        Console.WriteLine(new string('-', 40));

        // task 18
        var studentsByGroups =
            from student in students
            orderby student.GroupNumber
            select student;

        // task 19
        //var studentsByGroups = students.OrderBy(student => student.GroupNumber);

        Console.WriteLine("The students grouped by GroupNumber:");
        foreach (var student in studentsByGroups)
        {
            Console.WriteLine("* " + student.GroupNumber + ". " + student.FirstName + " " + student.LastName);
        }
    }
}
