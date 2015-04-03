namespace Infestation.Supplements
{
    public class InfestationSpores : Supplement
    {
        public InfestationSpores()
            : base(-1, 0, 20)
        {

        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                this.powerEffect = 0;
                this.aggressionEffect = 0;
            }
        }
    }
}
