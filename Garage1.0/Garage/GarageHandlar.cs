using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    public class GarageHandlar : IGarageHandlar
    {
        IGarage<Vehicle> garage = new Garage<Vehicle>(5);

        //public GarageHandlar(object obj) {
        //  garage = new Garage<Vehicle>(5);
        // }
        //public GarageHandlar(IGarage<Vehicle> gObj)
        //{

        //    gObj = new Garage<Vehicle>(5);
        //    Console.WriteLine("Garage with obj");
        //    //gObj.initializeVehicleArr(5);
        //    garage = gObj;
        //    Console.WriteLine("Garage is again obj");
        //}

        public bool GarageIsFull()
        {
            return garage.IsFull;
        }

        public bool GarageIsEmpty()
        {
            return garage.IsEmpty;
        }

        // ListAllVehicleInGarage
        public void ListAllVehicle()
        {
            if (!garage.IsEmpty)
            {
                int i = 0;
                foreach (var item in garage)
                {
                    i++;
                    Console.WriteLine(i + " " + item.Stats());
                }
            }
            else
                Console.WriteLine("Garage is Empty");
        }

        public void ParkVehicleinGarage(Vehicle v)
        {
            if (garage.IsFull)
                Console.WriteLine("Garage if full");


            else
            {
                bool alreadyExist = false;
                foreach (var ve in garage)
                {
                    if (ve.RegisterNum == v.RegisterNum)
                    {
                        alreadyExist = true;
                        Console.WriteLine("Two Vehicles canot have same Register Number");
                        break;
                    }
                }
                if (!alreadyExist)
                {
                    garage.AddVehicle(v);
                    Console.WriteLine($"Vehicle {v.Name} with Regnum: {v.RegisterNum} is now parked in Garage ");
                }
            }
        }

        public void RemoveVehiclefromGarage(string regNumber)
        {
            if (garage.IsEmpty)
                Console.WriteLine("garage is Empty");
            else
            {
                var v = garage.RemoveVehicle(regNumber);
                if (v == null)
                    Console.WriteLine($"Vehicle with regnum : {regNumber} is not parked in the Garage");
                else
                    Console.WriteLine($"Vehicle {v.Name} with RegNumber {v.RegisterNum} is removed from Garage ");
            }
        }

        public void FindVehicleinGarage(string regnum)
        {
            var result = garage.Where(v => v != null && v.RegisterNum == regnum).FirstOrDefault();
            if (result == null)
            {
                Console.WriteLine("Vehicle not found");
            }
            else
            {
                Console.WriteLine(result.Stats());
            }
            //foreach (var item in garage)
            //{
            //    if (item.RegisterNum == regnum)
            //    {
            //        Console.WriteLine(item.Stats());
            //        return;

            //    }

            //}

            //  Console.WriteLine($"Vehicle with {regnum} is not parked in the Garage");

        }

        public void ListVehicleByColor(string color)
        {
            var results = garage.Where(v => v != null && v.Color == color).ToArray();
            //return results;
            //var v = garage.FindVehicleByColor(color);
            if (results.Length == 0)
                Console.WriteLine($"Vehicles with {color} is not parked in Garage");
            else
            {

                foreach (var item in results)
                {
                    Console.WriteLine(item.Stats());
                }
            }
        }
        public void ListVehicleByColorAndWheenum(string color, int wheelnum)
        {
            var results = garage.Where(v => v != null && v.Color == color && v.WheelsNum == wheelnum).ToArray();
            if (results.Length == 0)
                Console.WriteLine($"Vehicles with {color} color and {wheelnum} no. of wheels is not parked in Garage");
            else
            {

                foreach (var item in results)
                {
                    Console.WriteLine(item.Stats());
                }
            }
        }

        public void ListVehicleByLength(double length) //´rename lenght to minimum length
        {
            bool found = false;
            foreach (var item in garage)
            {
                if (item is Boat b)
                {
                    if (b.Length >= length)
                    {
                        found = true;
                        Console.WriteLine(b.Stats());
                    }
                }

            }
            if (!found)
            {
                { Console.WriteLine("Boat does not exist"); }
            }

        }

        public void EmptyGarage()
        {
            garage.EmptyGarage();
        }
    }
}
