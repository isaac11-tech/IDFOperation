using System;


namespace redzone.AbstractClass


{
    public abstract class Weapon

    {
        public string Model { get; }
        public abstract int DangerRank { get; }


        public Weapon() { }
        public Weapon(string model) 
        {
           this.Model = model;
        }

       
        
    }
}