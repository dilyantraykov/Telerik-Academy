namespace AcademyEcosystem
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private const int BoarSize = 4;
        private const int BoarBiteSize = 2;

        public Boar(string name, Point location)
            : base(name, location, BoarSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                var meatEaten = 0;
                if (this.Size >= animal.Size)
                {
                    meatEaten = animal.GetMeatFromKillQuantity();
                }

                return meatEaten;
            }
            return 0;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                var quantityEaten = 0;
                quantityEaten = plant.GetEatenQuantity(BoarBiteSize);
                this.Size++;

                return quantityEaten;
            }
            return 0;
        }
    }
}
