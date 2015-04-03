using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        private const int NinjaAttackPoints = 0;
        private const int NinjaDefensePoints = int.MaxValue;
        private const int NinjaHitPoints = 1;

        private int attackPoints = NinjaAttackPoints;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = NinjaHitPoints;
        }

        public int AttackPoints
        {
            get { return attackPoints; }
            private set { this.attackPoints = value; }
        }

        public int DefensePoints
        {
            get { return NinjaDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var maxTarget = availableTargets
            .Where(t => t.Owner != 0 && t.Owner != this.Owner)
            .OrderByDescending(t => t.HitPoints).FirstOrDefault();

            return availableTargets.FindIndex(t => t == maxTarget);
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }
            return false;
        }
    }
}
