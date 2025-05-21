using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.strikeOptions
{
    public enum BombTypes
    {
        HalfTon = 1,
        OneTon = 2
    }
    internal class F16 : StrikeOptions
    {
        public BombTypes SelectedBomb { get; set; }

        public F16(string uniqueName, int ammunitionCapacity,
            int fuelSupply, TypesTarget effectiveTarget, BombTypes bomb)
            : base(uniqueName, ammunitionCapacity, fuelSupply, effectiveTarget)
        {
            if (ammunitionCapacity > 8)
            {
                Console.WriteLine("the limed is 8");
                ammunitionCapacity = 8;
            }
            SelectedBomb = bomb;
        }
    }
}
