using System.Collections.Generic;
using System.Linq;
using Infestation.Supplements;

namespace Infestation.Units
{
    public class Queen : InfestingUnit
    {
        public Queen(string id)
            : base(id, UnitClassification.Psionic, 30, 1, 1)
        {
        }
    }
}
