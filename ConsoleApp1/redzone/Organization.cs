using redzone.AbstractClass;
using redzone.Enemy;

namespace redzone.Organization 
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