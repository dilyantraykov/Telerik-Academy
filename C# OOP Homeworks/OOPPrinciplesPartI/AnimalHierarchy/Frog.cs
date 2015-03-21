using System;

namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(string name, byte age, Sex sex)
            : base(name, age, sex)
        {
        }

        public override string MakeSound()
        {
            return "ribbit!";
        }
    }
}
