using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
   public abstract class Vehicle : IVehicle
    {

        public string RegisterNum { get; }
        public string Color { get; }
        public int WheelsNum { get; }
        public string Name { get; }



        public Vehicle(string name, string regnum, string color, int wheelnum)
        {
            Name = name;
            RegisterNum = regnum;
            Color = color;
            WheelsNum = wheelnum;

        }

        public virtual string Stats()
        {
            return $"Name : {Name,-11} Register Number : {RegisterNum,-10} color : {Color,-10} No. of Wheels : {WheelsNum,-5} ";
        } 



    }
}
