using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Knight : Character, IFighter
    {
        private const int KnightAttackPoints = 100;
        private const int KnightDefensePoints = 100;
        private const int KnightHitPoints = 100;

        public Knight(string name, Point position, int owner)
            : base (name, position, owner)
        {
            this.HitPoints = KnightHitPoints;
        }

        public int AttackPoints
        {
            get { return KnightAttackPoints; }
        }

        public int DefensePoints
        {
            get { return KnightDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            return availableTargets.FindIndex(t => t.Owner != 0 && t.Owner != this.Owner);
        }
    }
}
