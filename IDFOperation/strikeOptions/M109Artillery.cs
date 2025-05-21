using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.strikeOptions
{
    internal class M109Artillery : StrikeOptions
    {
        public M109Artillery(string uniqueName, int ammunitionCapacity,
            int fuelSupply, string effectiveTarget)
            : base(uniqueName, ammunitionCapacity, fuelSupply, effectiveTarget)
        {


        }
    }
}
