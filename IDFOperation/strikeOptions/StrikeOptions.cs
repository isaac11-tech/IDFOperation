using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.strikeOptions
{
    public enum TypesTarget
    {
        Buildings,
        Cars,
        People,
        Bunkers
    }

    internal abstract class StrikeOptions
    {
        public string UniqueName { get; set; }
        public int AmmunitionCapacity { get; set; }
        public int FuelSupply { get; set; }
        public TypesTarget EffectiveTarget { get; set; }

        public StrikeOptions(string uniqueName, int ammunitionCapacity,
            int fuelSupply, TypesTarget effectiveTarget)
        {
 
            UniqueName = uniqueName;
            AmmunitionCapacity = ammunitionCapacity;
            FuelSupply = fuelSupply;
            EffectiveTarget = effectiveTarget;

        }

    }
}
