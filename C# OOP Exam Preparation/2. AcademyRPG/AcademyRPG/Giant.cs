using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private const int GiantAttackPoints = 150;
        private const int GiantDefensePoints = 80;
        private const int GiantHitPoints = 200;
        private const int AttackPointsBonusFromGatheringStone = 100;

        private bool hasGatheredStone = false;
        private int attackPoints = GiantAttackPoints;

        public Giant(string name, Point position)
            : base(name, position, 0)
        {
            this.HitPoints = GiantHitPoints;
        }

        public int AttackPoints
        {
            get { return attackPoints; }
            private set { this.attackPoints = value; }
        }

        public int DefensePoints
        {
            get { return GiantDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            return availableTargets.FindIndex(t => t.Owner != 0);
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!this.hasGatheredStone)
                {
                    this.hasGatheredStone = true;
                    this.AttackPoints += AttackPointsBonusFromGatheringStone;
                }
                return true;
            }
            return false;
        }
    }
}
