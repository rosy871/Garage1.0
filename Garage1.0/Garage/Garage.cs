using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    public class Garage<T> : IEnumerable<T>, IGarage<T> where T : Vehicle
    {
        private IVehicle[] vehicleArray;
        private int index;
        public int Capacity { get; set; }


        public Garage(int capacity)
        {
            index = 0;
            Capacity = capacity;
            if (Capacity <= 0)
                Capacity = 1;

            vehicleArray = new Vehicle[Capacity];

        }

        //public bool IsFull2()
        //{
        //    return true;
        //}


        public bool IsFull
        {
            get { return index >= Capacity; }
        }
        public void AddVehicle(IVehicle veh)
        {
            vehicleArray[index] = veh;
            index++;
            Console.WriteLine($"Vehicle {veh.RegisterNum} is parked in Garage");
        }

        public bool IsEmpty
        {
            get { return index <= 0; }
        }
        public void EmptyGarage()
        {
            index = 0;
        }
        public IVehicle RemoveVehicle(string regNum)
        {

            //vehicleArray = vehicleArray.Where(v => v.RegisterNum != regNum).ToArray();

            var toBeRemoved = vehicleArray.Where(v => v != null && v.RegisterNum == regNum).FirstOrDefault();
            if (toBeRemoved == null)
                return toBeRemoved;

            int ind = Array.IndexOf(vehicleArray, toBeRemoved);
            Console.WriteLine("index of removed veh" + ind);
            for (int i = ind; i < vehicleArray.Length - 1; i++)
            {
                vehicleArray[i] = vehicleArray[i + 1];

            }

            vehicleArray[index - 1] = null;
            index--;
            //Console.WriteLine(toBeRemoved.Stats());
            //Console.WriteLine($"Vehicle {toBeRemoved.RegisterNum} is removed from Garage");
            return toBeRemoved;
        }

        //public void showParkedVehicle()
        //{
        //    Console.WriteLine("lenght of filled array : " + vehicleArray.Length);
        //    for (int i = 0; i < index; i++)
        //    {

        //        Console.WriteLine(vehicleArray[i].Stats());
        //    }

        //}

        //public IVehicle FindVehicle(string regnum)
        //{
        //    IVehicle toFind = vehicleArray.Where(v => v != null && v.RegisterNum == regnum).FirstOrDefault();
        //    return toFind;

        //}

        //public IEnumerable<IVehicle> FindVehicleByColor(string color)
        //{
        //   var results = vehicleArray.Where(v => v != null && v.Color == color).ToArray();
        //     return results;
        //}

        // //public Vehicle[] FindVehicleByColorAndWheelNum(string color, int wheelnum)
        // public IEnumerable<IVehicle> FindVehicleByColorAndWheelNum(string color, int wheelnum)
        //{
        //    var results = vehicleArray.Where(v => v != null && v.Color == color && v.WheelsNum == wheelnum).ToArray();
        //    return results;

        //}


        //void TaBort()
        //{
        //    var garage1 = new Garage<Vehicle>(5);
        //    foreach (var vehicle in garage1)
        //    {

        //    }
        //}

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                if (vehicleArray[i] is T veh)
                {
                    yield return (veh);
                }


            }
            //foreach (var item in vehicleArray)
            //{
            //    yield return item;
            //}
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
