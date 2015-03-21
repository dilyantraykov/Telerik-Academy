/*
Problem 1. School classes

We are given a school. In the school there are classes of students. Each class has a set of teachers. 
Each teacher teaches a set of disciplines. Students have name and unique class number.
Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures
and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines
could have optional comments (free text block).

Your task is to identify the classes (in terms of OOP) and their attributes and operations,
encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
*/

using System;
using System.Collections.Generic;

namespace SchoolClasses
{
    class TestSchool
    {
        static void Main()
        {
            var school = new School("First English Language School");
            var students = new List<Student>
            {
                new Student("Slim", "Shady", 45000),
                new Student("Doctor", "Dre", 45002),
                new Student("Snoop", "Dog", 45005),
                new Student("T", "Pain", 45009)
            };

            var disciplines = new Dictionary<string, Discipline>
            {
                { "HTML", new Discipline("HTML", 5, 20) },
                { "CSS", new Discipline("CSS", 5, 20) },
                { "C#", new Discipline("C#", 12, 100) },
                { "JavaScript", new Discipline("JavaScript", 12, 120) },
                { "SQL", new Discipline("SQL", 4, 15) }
            };

            var teachers = new List<Teacher>
            {
                new Teacher("Nikolay", "Kostov", new List<Discipline> { disciplines["C#"] }),
                new Teacher("Doncho", "Mitkov", new List<Discipline> { disciplines["JavaScript"], disciplines["CSS"] }),
                new Teacher("Ivaylo", "Kenov", new List<Discipline> { disciplines["C#"], disciplines["SQL"] }),
                new Teacher("Evlogy", "Georgiev", new List<Discipline> { disciplines["JavaScript"], disciplines["HTML"] }),
            };

            var classes = new List<Class>
            {
                new Class("12D"),
                new Class("12V")
            };


            foreach (var @class in classes)
            {
                school.AddClass(@class);
            }

            @classes[1].AddTeacher(teachers[2]);

            foreach (var @class in school.GetClasses())
            {
                Console.WriteLine(@class);
            }

            classes[0].AddComment("This is a looooooooooong comment!");
            Console.Write(classes[0].Comments);

            // feel free to test the other functionalities out
        }
    }
}
