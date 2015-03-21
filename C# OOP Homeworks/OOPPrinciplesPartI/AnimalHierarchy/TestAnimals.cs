using System;

namespace AnimalHierarchy
{
    class TestAnimals
    {
        static void Main()
        {
            var dogs = new[] { new Dog("Sharo", 10, Sex.Female), new Dog("Rex", 12, Sex.Male) };
            var kittens = new[] { new Kitten("Kotio", 2), new Kitten("Maca", 3) };
            var tomcats = new[] { new Tomcat("Tom", 3), new Tomcat("Gele", 2), new Tomcat("Mike", 3) };
            var frogs = new[] { new Frog("Skoklio", 7, Sex.Female), new Frog("Gosho", 3, Sex.Male) };

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
            }

            Console.WriteLine();

            foreach (var kitten in kittens)
            {
                Console.WriteLine(kitten);
            }

            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();

            Console.WriteLine("Average dog age: {0:F2} years.", Animal.AverageAge(dogs));
            Console.WriteLine("Average kitten age: {0:F2} years.", Animal.AverageAge(kittens));
            Console.WriteLine("Average tomcat age: {0:F2} years.", Animal.AverageAge(tomcats));
            Console.WriteLine("Average frog age: {0:F2} years.", Animal.AverageAge(frogs));
        }
    }
}
