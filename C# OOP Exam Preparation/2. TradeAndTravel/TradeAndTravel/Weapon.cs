using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Weapon : Item
    {
        const int GeneralWeaponValue = 10;

        public Weapon(string name, Location location = null)
            : base(name, Weapon.GeneralWeaponValue, ItemType.Weapon, location)
        {
        }
    }
}
