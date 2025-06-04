using redzone.Organization;
using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace redzone.general

{
    public class commandsMenu
    {
        public static void Menu()
        {
            int input = 0;
            do
            {
                Console.WriteLine("please choose ann option from 1-4,0 for exit");

                bool correctInput = int.TryParse(Console.ReadLine(), out input);

                if (correctInput)
                {
                    switch (input)
                    {
                        case 1:
                            Commands.MostReported(hammas);
                            break;
                        case 2:
                            Commands.MostDanger(hammas);
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                }
            }
            while (input != 0);

        }
    }

}
  
