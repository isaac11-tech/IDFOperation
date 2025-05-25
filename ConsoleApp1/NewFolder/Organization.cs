using ConsoleApp1.AbstractClass;
using ConsoleApp1.Enemy;

namespace ConsoleApp1.Organization 
{ 
  public class Hammas
    {
        private int DateOfFormation { get; }
        private string Description { get; set; }
        private string Commander { get; set; }
        private List<Terrorist> Afilliates { get; } = new List<Terrorist>();

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