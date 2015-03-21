using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(string name, byte age, Sex sex)
            : base(name, age, sex)
        {
        }

        public override string MakeSound()
        {
            return "meow!";
        }
    }
}
