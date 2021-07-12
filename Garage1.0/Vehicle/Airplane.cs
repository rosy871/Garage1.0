using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
   public class Airplane : Vehicle
    {
        public int EngineNum { get; }
        public Airplane(string name,string regnum, string color, int wheelnum, int enginenum):base(name,regnum,color,wheelnum)
        {
            EngineNum = enginenum;
        }

        public override string Stats()
        {
            return base.Stats() + $"No. of Engines : {EngineNum,3} ";
        }


    }
}
