using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Car:Vehicle
    {
        public string FuelType { get;  }
        public Car(string name,string regnum, string color, int wheelnum, string fuelType ):base(name,regnum,color, wheelnum)
        {
            FuelType = fuelType; 
        }

        public override string Stats()
        {
            return base.Stats() + $"FuelType: {FuelType}";
        }
    }
}
