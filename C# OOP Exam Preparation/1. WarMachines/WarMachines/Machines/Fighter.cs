using System.Text;
using WarMachines.Interfaces;

namespace WarMachines
{
    public class Fighter : Machine, IFighter
    {
        private bool stealthMode;
        public Fighter(string name, double attackPoints, double defensePoints, bool stealth)
            : base(name, attackPoints, defensePoints)
        {
            this.HealthPoints = 200;
            this.stealthMode = stealth;
        }

        public bool StealthMode
        {
            get { return this.stealthMode; }
        }

        public void ToggleStealthMode()
        {
            this.stealthMode = !this.stealthMode;
        }

        public string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine(string.Format(" *Stealth: {0}", stealthMode ? defaultOnWord : defaultOffWord));

            return result.ToString().Trim();
        }
    }
}
