using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using ConsoleApp1.Enemy;
using ConsoleApp1.message;
using ConsoleApp1.Organization;
using ConsoleApp1.commands;

namespace ConsoleApp1.NewFolder
{
    public class demo
    {
        static void Main(string[] args)
        {
            Intelligence AMAN = new Intelligence();
            string data = "hammas";
            Hammas HammasOrganization = new Hammas(data, "unknown");

            Terrorist t = new Terrorist("muhamad", 2, "hammas", 'a');
            HammasOrganization.AddAfilliate(t);
            Terrorist o = new Terrorist("mhamad", 4, "hammas", 'a');
            HammasOrganization.AddAfilliate(o);
            Terrorist tv = new Terrorist("muhmad", 5, "hammas", 'a');
            HammasOrganization.AddAfilliate(tv);
            Terrorist ov = new Terrorist("muhmad", 1, "hammas", 'a');
            HammasOrganization.AddAfilliate(ov);
            Terrorist pt = new Terrorist("muhamud", 3, "hammas", 'd');
            HammasOrganization.AddAfilliate(pt);

            foreach(var i in HammasOrganization.Afilliates)
            {
                Message m = new Message(i, "home");
                AMAN.AddMessage(m);
            }
           

           Commands.MostDanger(HammasOrganization);

           Commands.MostReported(HammasOrganization);


            

        }
    }
}
