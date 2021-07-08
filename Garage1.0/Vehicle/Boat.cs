using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    public class Boat:Vehicle
    {
        public double Length { get; }
        public Boat(string name,string regnum, string color, int wheelnum, double length):base(name,regnum, color, wheelnum)
        {
            Length = length;
        }

        public override string Stats()
        {
            return base.Stats() + $"Lenght : {Length} m";
        }
    }
}
