using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Forest : Location
    {
        public Forest(string name)
            : base(name, LocationType.Forest)
        {
        }
    }
}
