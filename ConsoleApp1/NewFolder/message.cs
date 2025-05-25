using System;
using ConsoleApp1.Enemy;
 
namespace ConsoleApp1.message
{
    public class Message
    {
        private Terrorist Wanted {  get; set; }
        private string Location { get; set; }
        private DateTime TimeStamp { get; set; }


        public Message(Terrorist wanted, string Location)
        {
            this.Wanted = wanted;
            this.Location = Location;
            TimeStamp = DateTime.Now;
        }

        public void Info()
        {
            Console.WriteLine($"name:{this.Wanted.Name}\n{Location}\n{TimeStamp}");
        }






    }
}
