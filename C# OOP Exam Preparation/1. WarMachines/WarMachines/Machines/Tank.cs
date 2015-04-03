using System;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines
{
    public class Tank : Machine, ITank
    {
        private bool defenseMode = false;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints)
        {
            this.HealthPoints = 100;
            ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get { return this.defenseMode; }
        }

        public void ToggleDefenseMode()
        {
            this.defenseMode = !this.defenseMode;
            if (defenseMode)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
            else
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
        }

        public string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine(string.Format(" *Defense: {0}", defenseMode ? defaultOnWord : defaultOffWord));

            return result.ToString().Trim();
        }
    }
}
