using System;
using ConsoleApp1.Enemy;
using ConsoleApp1.NewFolder;
using ConsoleApp1.Organization;
using ConsoleApp1.assistance;

namespace ConsoleApp1.commands
{

    public class Commands
    {

        public static void MostReported(Hammas h)
        {
            Dictionary<string, int> sortedByDanger = AssistanceFunctions.SortByRank(h.Afilliates);

            string mostReported = AssistanceFunctions.KeyOfMaxValue(sortedByDanger);

            Console.WriteLine($" the terrorist with most message is: {mostReported}");

        }









        public static void MostDanger(Hammas h)
        {
            List<Terrorist> terrorList = h.Afilliates;
            string info ="";
            int max = 0;

            foreach (var t in terrorList)
            {
                
                if (t.GetTotalScore() >= max)                      //          finding most danger terrorist object
                {
                    var mostDanger = t;
                    max = t.GetTotalScore();
                    info = mostDanger.Info();
                }

            }
            
            Console.WriteLine($"--{info}--");

            //     return the information about this terrorist
        }








    }

}
