using System;
using System.Collections.Generic;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines
{
    public abstract class Machine : IMachine
    {
        public const string defaultOnWord = "ON";
        public const string defaultOffWord = "OFF";

        protected string name;
        protected IPilot pilot;
        protected double attackPoints;
        protected double defensePoints;
        protected IList<string> targets;

        protected Machine(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.pilot = null;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get { return this.pilot; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints
        {
            get { return this.attackPoints; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.defensePoints = value;
            }
        }

        public IList<string> Targets
        {
            get { return this.targets; }
        }

        public void Attack(string target)
        {
            targets.Add(target);
        }

        public string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("- {0}", this.Name));
            result.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            result.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            result.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            result.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            var targets = this.Targets.Count == 0 ? "None" : string.Join(", ", this.Targets);
            result.AppendLine(string.Format(" *Targets: {0}", targets));

            return result.ToString().Trim();
        }
    }
}
