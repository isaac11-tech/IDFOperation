using System;
using System.Numerics;
using ConsoleApp1.AbstractClass;


namespace ConsoleApp1.Enemy
{
    public class Terrorist
    {
        public string Name { get; }
        public int Rank { get; set; }
        public string Organizational_Afilliation { get; set; }
        
        private int dangerCounter;
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
            dangerCounter += x.DangerRank;
        }
        public void RemoveWeapon(Weapon x)
        {
            Weapons.Remove(x);
            dangerCounter -= x.DangerRank;
        }

        public int GetTotalScore()
        {
            return Rank * dangerCounter;
        } 

        public string Info()
        {
            return $"{Name}\n affiliate in{Organizational_Afilliation}\nrank:{Rank}";
        }


    }
}
