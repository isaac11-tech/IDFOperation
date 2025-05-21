using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.strikeOptions
{
    internal class Hermes460Drone : StrikeOptions
    {
        public Hermes460Drone(string uniqueName, int ammunitionCapacity,
            int fuelSupply, string effectiveTarget)
            : base(uniqueName, ammunitionCapacity, fuelSupply, effectiveTarget)
        {


        }
    }
}
