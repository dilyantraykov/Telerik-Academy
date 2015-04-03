using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines
{
    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} - {1} {2}",
                this.Name, 
                this.machines.Count == 0 ? "no" : this.machines.Count.ToString(),
                this.machines.Count == 1 ? "machine" : "machines"));
            if (this.machines.Count > 0)
            {
                var sortedMachines = this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);
                foreach (var machine in sortedMachines)
                {
                    result.AppendLine(machine.ToString());
                }
            }

            return result.ToString().Trim();
        }
    }
}
