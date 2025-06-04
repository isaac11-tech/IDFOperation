using System;
using bluezone;

namespace redzone.general
{
    public class Commands
    {
        //   method to find the most reported terrorist, using methods 'SOrtByRank' and ' KeyOfMaxValue'
        public static void MostReported(Hammas h)
        {
            Dictionary<string, int> sortedByDanger = AssistanceFunctions.SortByRank(h.Afilliates);

            string mostReported = AssistanceFunctions.KeyOfMaxValue(sortedByDanger);

            Console.WriteLine($" the terrorist with most message is: {mostReported}");

        }








        //  method to retrieve the most dangerous terrorist
        public static void MostDanger(Hammas h)
        {
            List<Terrorist> terrorList = h.Afilliates;
            string info = "";
            int max = 0;

            foreach (var t in terrorList)
            {

                if (t.GetTotalScore() >= max)                                 //   finding most danger terrorist object
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