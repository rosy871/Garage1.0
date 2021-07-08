using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
   public class Vehicle : IVehicle
    {
        public string RegisterNum { get; }
        public string Color { get; }
        public int WheelsNum { get; }
        public string Name { get;  }

       

        public Vehicle(string name, string regnum, string color, int wheelnum)
        {
            Name = name;
            RegisterNum = regnum;
            Color = color;
            WheelsNum = wheelnum;

        }

        public virtual string Stats()
        {
            return $"Name: {Name,-13} Register Number:{RegisterNum,-10} color:{Color,-10} no. of wheels: {WheelsNum,-5}  ";
        } 



    }
}
