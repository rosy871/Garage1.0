using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
   public class Motorcyckle: Vehicle
    {
        public int CylinderCapacity { get;  }
        public Motorcyckle(string name,string regnum, string color, int wheelnum, int cylindervol):base(name,regnum,color, wheelnum)
        {
            CylinderCapacity = cylindervol;
        }

        public override string Stats()
        {
            return base.Stats() + $"Cylinder Capacity: {CylinderCapacity}cc";
        }
    }
}
