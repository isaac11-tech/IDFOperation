using System;
using redzone.Enemy;

namespace redzone.bluezone
{
    public class Message
    {
        private Terrorist Wanted {  get; set; }
        private string Location { get; set; }
        private DateTime TimeStamp { get; set; }


        public Message(Terrorist wanted, string Location)
        {
            Wanted = wanted;
            this.Location = Location;
            TimeStamp = DateTime.Now;
        }

        public void Info()
        {
            Console.WriteLine($"name:{Wanted.Name}\nlocation: {Location}\n--{TimeStamp}--\n");
        }






    }
}
