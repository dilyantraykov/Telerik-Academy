using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Lion : Animal, ICarnivore
    {
        private const int LionSize = 6;

        public Lion(string name, Point location)
            : base(name, location, LionSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                var meatEaten = 0;
                if (this.Size >= animal.Size / 2)
                {
                    meatEaten = animal.GetMeatFromKillQuantity();
                    this.Size++;
                }

                return meatEaten;
            }
            return 0;
        }
    }
}
