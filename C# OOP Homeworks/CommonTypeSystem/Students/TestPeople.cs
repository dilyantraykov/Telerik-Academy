using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class TestPeople
    {
        static void Main()
        {
            var student1 = new Student("Slim", "Marshal", "Shady", 666666666, "Detroit", "+35988888888", "slim.shady@gmail.com",
                3, Specialties.Psychology, Universities.SofiaUniversity, Faculties.Europeistics);
            Console.WriteLine(student1.GetHashCode());

            var student2 = new Student("Doctor", "Young", "Dre", 666222666, "Detroit", "+35988888888", "doctor.dre@gmail.com",
                4, Specialties.Phylosophy, Universities.TechnicalUniversity, Faculties.Languages);
            Console.WriteLine(student2.GetHashCode());

            Console.WriteLine();

            Console.WriteLine(student1);
            Console.WriteLine();

            Console.WriteLine(student2);
            Console.WriteLine();

            Console.WriteLine("student1 == student2 : {0}", student1 == student2);
            Console.WriteLine("student1 != student2 : {0}", student1 != student2);
            Console.WriteLine("student1.Equals(student1) : {0}", student1.Equals(student1));
            Console.WriteLine("student1.Equals(student2) : {0}", student1.Equals(student2));
            Console.WriteLine();

            var person1 = new Person("Slim Shady", 42);
            var person2 = new Person("Doctor Dre");

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
