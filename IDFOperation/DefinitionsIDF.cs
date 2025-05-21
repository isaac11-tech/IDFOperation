using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.strikeOptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IDFOperation
{
    internal class DefinitionsIDF
    {
        public DateTime DateOfEstablishment {  get; set; }

        public string CurrentCommander { get; set; }

        public List<StrikeOptions> Options { get; set; }

        public DefinitionsIDF(string currentCommander)
        {
            this.CurrentCommander = currentCommander;
            this.DateOfEstablishment = new DateTime(1948, 5, 26);
            Options = new List<StrikeOptions>();
            updataSearchOption();

        }

        private void updataSearchOption()
        {
            F16 f16 = new F16("Eagle", 8,150,TypesTarget.Buildings,BombTypes.HalfTon);

            //Hermes460Drone h460 = new Hermes460Drone();
            //M109Artillery m109 = new M109Artillery();
            //Options.Add(f16);
           // Options.Add(h460);
           // Options.Add(m109);
        }

    }
}
