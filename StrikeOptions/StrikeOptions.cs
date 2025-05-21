using System.Xml;
namespace StrikeOptions
{
    public abstract class StrikeOptions
    {
        public string UniqueName {  get; set; }
        public int AmmunitionCapacity {  get; set; }
        public int FuelSupply {  get; set; }
        public string EfectiveTarget {  get; set; }

        public StrikeOptions(string uniqueName, int ammunitionCapacity,
            int fuelSupply, string efectiveTarget)
        {
            UniqueName = uniqueName;
            ammunitionCapacity = AmmunitionCapacity;
            FuelSupply = fuelSupply;
            EfectiveTarget = efectiveTarget;

        }



    }
}
