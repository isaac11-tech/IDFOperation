using System;
using redzone.AbstractClass;

namespace Munitions
{
    public class Gun : Weapon
    {
        public override int DangerRank { get; }

        public Gun()
        {
            this.DangerRank = 2;
        }

    }



    public class Rifle : Weapon
    {
        public override int DangerRank { get; }
        public Rifle(string model)
         :base(model)
        {     
           this.DangerRank = 3;
        }

    }
    public class Knife:Weapon
    {
        public override int DangerRank { get; }
        public Knife()
        {
            this.DangerRank = 1;
        }

    }


}
