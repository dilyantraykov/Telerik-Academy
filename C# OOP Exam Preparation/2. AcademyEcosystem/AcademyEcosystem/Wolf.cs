namespace AcademyEcosystem
{
    public class Wolf : Animal, ICarnivore
    {
        private const int WolfSize = 4;

        public Wolf(string name, Point location)
            : base(name, location, WolfSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                var meatEaten = 0;
                if (this.Size >= animal.Size || animal.State == AnimalState.Sleeping)
                {
                    meatEaten = animal.GetMeatFromKillQuantity();
                }

                return meatEaten;
            }
            return 0;
        }
    }
}
