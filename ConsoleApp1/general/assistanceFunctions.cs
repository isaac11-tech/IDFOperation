using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using redzone.Enemy;

namespace redzone.general
{
    public class AssistanceFunctions
    {
        public static Dictionary<string, int> SortByRank(List<Terrorist> terroristList)    //   sorting the list to dictionary by name and rank as key alue pairs
        {
            Dictionary<string, int> terroristsDict = new Dictionary<string, int>();

            foreach (var t in terroristList)
            {
                if (terroristsDict.ContainsKey(t.Name))
                {
                    terroristsDict[t.Name] = +1;
                }
                else
                {
                    terroristsDict.Add(t.Name, +1);
                }
            }
            return terroristsDict;
        }


        public static string KeyOfMaxValue(Dictionary<string, int> dict)    //   finding biggest value and  return his key
        {
            int max = 0;
            string keyOfMax = "";
            foreach (var i in dict)
            {
                if (i.Value > max)
                {
                    max = i.Value;
                    keyOfMax = i.Key;

                }
            }
            return keyOfMax;
        }


        //public static int[] DictKeysToInt(Dictionary<string, int> dict)
        //{
        //    int[] sortingParsed = new int[dict.Count];           // a list in dict length
        //    int x = 0;                                                     //        a counter for looping on sortedParsed array

        //    foreach (var i in dict.Keys)
        //    {
        //        bool parsed = int.TryParse(i.ToString(), out int result);
        //        if (parsed)
        //        {
        //            sortingParsed[x] = result;
        //            x++;
        //        }
        //    }
        //    return sortingParsed;
        //}

    }
}
