namespace Infestation
{
    public class Weapon : Supplement
    {
        public Weapon()
            : base(0, 0, 0)
        {

        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.powerEffect = 10;
                this.aggressionEffect = 3;
            }
        }
    }
}
