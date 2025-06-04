using System;
using System.Numerics;
using redzone.AbstractClass;


namespace redzone.Enemy
{
    public class Terrorist
    {
        public string Name { get; }
        public int Rank { get; set; }
        public string Organizational_Afilliation { get; set; }
        
        public int DangerCounter { get; set; }
        public char Status { get; set; }
        public List<Weapon> Weapons { get; } = new List<Weapon>();
        public Terrorist(string name, int rank, string affiliation, char status)
        {
            this.Name = name;
            this.Rank = rank;
            this.Organizational_Afilliation = affiliation;
            this.Status = status;
        }
        public void AddWeapon(Weapon x)
        {
            Weapons.Add(x);
            DangerCounter += x.DangerRank;
        }
        public void RemoveWeapon(Weapon x)
        {
            Weapons.Remove(x);
            DangerCounter -= x.DangerRank;
        }

        public int GetTotalScore()
        {
            return Rank * DangerCounter;
        } 

        public string Info()
        {
            return $"name: {Name}\naffiliates in: {Organizational_Afilliation}\nrank: {Rank}\nstatus: {Status}\n";
        }


    }
}
