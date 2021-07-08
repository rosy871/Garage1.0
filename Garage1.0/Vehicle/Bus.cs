using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
   public class Bus: Vehicle
    {
        public int SeatNums { get; }
        public Bus(string name, string regnum, string color, int wheelnum, int seatnum):base(name, regnum, color, wheelnum)
        {
            SeatNums = seatnum;
        }

        public override string Stats()
        {
            return base.Stats() + $"No. of Seats : {SeatNums,6} ";
        }
    }
}
