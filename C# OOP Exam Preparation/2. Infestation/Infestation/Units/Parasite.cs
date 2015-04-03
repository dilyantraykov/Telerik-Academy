using System.Collections.Generic;
using System.Linq;
using Infestation.Supplements;

namespace Infestation.Units
{
    public class Parasite : InfestingUnit
    {
        public Parasite(string id)
            : base(id, UnitClassification.Biological, 1, 1, 1)
        {
        }
    }
}
