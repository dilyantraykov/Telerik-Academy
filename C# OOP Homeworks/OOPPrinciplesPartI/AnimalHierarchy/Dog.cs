using System;

namespace AnimalHierarchy
{
    public class Dog : Animal
    {
        public Dog(string name, byte age, Sex sex)
            : base(name, age, sex)
        {
        }

        public override string MakeSound()
        {
            return "woof!";
        }
    }
}
