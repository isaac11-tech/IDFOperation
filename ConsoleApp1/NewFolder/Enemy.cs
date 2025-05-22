using System;
using ConsoleApp1.AbstractClass;


namespace ConsoleApp1.Enemy
{
    public class Terrorist
    {
        private string Name { get; }
        private int Rank { get; set; }
        private string Organizational_Afilliation { get; set; }
        private char Status { get; set; }
        private List<Weapon> Weapons { get; } = new List<Weapon>();


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
        }
        public void RemoveWeapon(Weapon x)
        {
            Weapons.Remove(x);
        }





    }
}
