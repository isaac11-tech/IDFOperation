using System;
using ConsoleApp1.Enemy;


namespace ConsoleApp1.commands
{
    public class Commands
    {
        public static string MostDanger(Terrorist[] terrorists)
        {
            string data = "";
            int max = 0;
            foreach (var terrorist in terrorists)
            {
                if (terrorist.GetTotalScore() > max)
                {
                    max = terrorist.GetTotalScore();
                    var mostDanger = terrorist;
                    data = mostDanger.Info();
                }
            }
            return data;
        }

        public string AmmunitionCapacity()
        {




            return "";
        }

        




    }
}
