using ConsoleApp1.AbstractClass;
using ConsoleApp1.Enemy;

namespace ConsoleApp1.Organization 
{ 
  public class Hammas
    {
        public int DateOfFormation { get; }
        public string Description { get; set; }
        public string Commander { get; set; }
        
        public List<Terrorist> Afilliates { get; }  = new List<Terrorist>();

        public Hammas(string description, string commander)
        {
            this.DateOfFormation = 1987;
            this.Description = description;
            this.Commander = commander;
        }
        public void AddAfilliate(Terrorist x)
        {
            Afilliates.Add(x);
        }
        public void RemoveAfilliate(Terrorist x)
        {
            Afilliates.Remove(x);
        }

       
    }

    
}