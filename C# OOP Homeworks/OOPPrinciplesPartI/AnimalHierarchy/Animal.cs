using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private string name;

        public byte Age { get; set; }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name should not be empty!");
                }
                this.name = value;
            }
        }

        public Sex Gender { get; set; }

        public Animal(string name, byte age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = sex;
        }

        public virtual string MakeSound()
        {
            return "hmmm...";
        }

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }

        public override string ToString()
        {
            return String.Format("{0} says {1}", this.Name, this.MakeSound());
        }
    }
}
