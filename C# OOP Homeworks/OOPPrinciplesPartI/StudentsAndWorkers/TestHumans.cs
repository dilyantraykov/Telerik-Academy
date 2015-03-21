/*
Problem 2. Students and workers

Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade.
Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker.
Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    class TestHumans
    {
        static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Slim", "Shady", 67));
            students.Add(new Student("Snoop", "Kenov", 55));
            students.Add(new Student("Doncho", "Mitkov", 88));
            students.Add(new Student("Evlogi", "Shady", 96));
            students.Add(new Student("Snoop", "Dog", 97));
            students.Add(new Student("Doctor", "Hristov", 22));
            students.Add(new Student("Ivaylo", "Kenov", 33));
            students.Add(new Student("Nikolay", "Krustev", 99));
            students.Add(new Student("Snoop", "Lion", 61));
            students.Add(new Student("Doctor", "Shady", 26));

            var workers = new List<Worker>();
            workers.Add(new Worker("Slim", "Shady", 1200, 8));
            workers.Add(new Worker("Snoop", "Kenov", 1250, 8));
            workers.Add(new Worker("Doncho", "Mitkov", 1600, 7));
            workers.Add(new Worker("Evlogi", "Shady", 1700, 7));
            workers.Add(new Worker("Snoop", "Dog", 1100, 6));
            workers.Add(new Worker("Doctor", "Hristov", 1051, 9));
            workers.Add(new Worker("Ivaylo", "Kenov", 1122, 6));
            workers.Add(new Worker("Nikolay", "Krustev", 990, 7));
            workers.Add(new Worker("Snoop", "Lion", 828, 9));
            workers.Add(new Worker("Doctor", "Shady", 1000, 7));

            students = students.OrderBy(x => x.Grade).ToList();
            workers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            Console.WriteLine("Students sorted by grade:");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(String.Join("\n", students));
            Console.WriteLine();

            Console.WriteLine("Workers sorted by money per hour:");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(String.Join("\n", workers));
            Console.WriteLine();

            var humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            humans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            Console.WriteLine("Humans sorted by first and last name:");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(String.Join("\n", humans.Select(x => String.Format("{0} {1}", x.FirstName, x.LastName))));
        }
    }
}
