using IDFOperation.strikeOptions;


namespace IDFOperation
{
    internal class DefinitionsIDF
    {
        public DateTime DateOfEstablishment {  get; set; }//finel? 

        public string CurrentCommander { get; set; }

        public List<StrikeOptions> Options { get; set; }

        public DefinitionsIDF(string currentCommander)
        {
            this.CurrentCommander = currentCommander;
            this.DateOfEstablishment = new DateTime(1948, 5, 26);
            Options = new List<StrikeOptions>();
            updataStrikeOption();
        }

        //Initial weapon quantity initialization
        private void updataStrikeOption()
        {
            F16 f161 = new F16("Eagle", 8,150,TypesTarget.Buildings,BombTypes.HalfTon);
            F16 f162 = new F16("adir", 8, 150, TypesTarget.Buildings, BombTypes.HalfTon);
            F16 f163 = new F16("night", 8, 150, TypesTarget.Buildings, BombTypes.HalfTon);
            Hermes460Drone h4601 = new Hermes460Drone("oz",40,100,TypesTarget.Cars);
            Hermes460Drone h4602 = new Hermes460Drone("sky", 40, 100, TypesTarget.Cars);
            Hermes460Drone h4603 = new Hermes460Drone("king", 40, 100, TypesTarget.Cars);
            M109Artillery m1091 = new M109Artillery("m109",100,7,TypesTarget.People);
            M109Artillery m1092 = new M109Artillery("m109", 100, 7, TypesTarget.People);
            M109Artillery m1093 = new M109Artillery("m109", 100, 7, TypesTarget.People);

            Options.Add(f161);
            Options.Add(f162);
            Options.Add(f163);
            Options.Add(h4601);
            Options.Add(h4602);
            Options.Add(h4603);
            Options.Add(m1091);
            Options.Add(m1092);
            Options.Add(m1093);
        }

       public void WeaponsReport()
        {
            foreach (StrikeOptions weapon in Options)
            {
                Console.WriteLine($"Unique name: {weapon.UniqueName} ," +
                    $"Ammunition capacity: {weapon.AmmunitionCapacity} ," +
                    $"FuelSupply: {weapon.FuelSupply} ," +
                    $"EffectiveTarget: {weapon.EffectiveTarget}");
            }
        }

    }
}
