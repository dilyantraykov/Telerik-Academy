using System.Collections.Generic;
using System.Linq;

namespace Infestation.Units
{
    public class Marine : Human
    {
        public Marine(string id)
            : base(id)
        {
            this.AddSupplement(new WeaponrySkill());
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            //This method finds the unit with the least power and attacks it
            //UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, this.Aggression, 0);

            var optimalAttackableUnits = attackableUnits.OrderByDescending(u => u.Health).ToList();

            if (optimalAttackableUnits.Count > 0)
            {
                return optimalAttackableUnits[0];
            }

            return new UnitInfo();
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Attack);
            }

            return Interaction.PassiveInteraction;
        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            bool attackUnit = false;
            if (this.Id != unit.Id)
            {
                if (this.Aggression >= unit.Power)
                {
                    attackUnit = true;
                }
            }
            return attackUnit;
        }
    }
}
