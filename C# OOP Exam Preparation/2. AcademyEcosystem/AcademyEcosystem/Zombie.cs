namespace AcademyEcosystem
{
    public class Zombie : Animal
    {
        private const int ZombieMeatQuantity = 10;

        public Zombie(string name, Point location)
            : base(name, location, 0)
        {
        }

        public override int GetMeatFromKillQuantity()
        {
            return ZombieMeatQuantity;
        }
    }
}
