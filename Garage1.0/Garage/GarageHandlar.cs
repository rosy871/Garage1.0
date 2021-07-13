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


        public bool GarageIsFull()
        {
            return garage.IsFull;
        }

        public bool GarageIsEmpty()
        {
            return garage.IsEmpty;
        }

        // ListAllVehicleInGarage
        public void ListAllVehicle(IUI ui)
        {
            if (!garage.IsEmpty)
            {
                int i = 0;
                ui.Print("\n---All Vechicles Lists:---");
                foreach (var item in garage)
                {
                    i++;
                    ui.Print(i + " " + item.Stats());
                }
            }
            else
                ui.Print("\nGarage is Empty");
        }

        public void ParkVehicleinGarage(Vehicle v, IUI ui)
        {
            var result = garage.Where(veh => veh.RegisterNum == v.RegisterNum).FirstOrDefault();
            if (result == null)
            {
                garage.AddVehicle(v);
            }
            else
                ui.Print("\nTwo Vehicles canot have same Register Number");



        }

        public void RemoveVehiclefromGarage(string regNumber, IUI ui)
        {

            var v = garage.RemoveVehicle(regNumber);
            if (v == null)
                ui.Print($"\nVehicle with regnum : {regNumber} is Not Parked in the Garage");
            else
                ui.Print($"\nVehicle {v.Name} with RegNumber {v.RegisterNum} is Removed from Garage ");

        }

        public void FindVehicleinGarage(string regnum, IUI ui)
        {
            var result = garage.Where(v => v != null && v.RegisterNum == regnum).FirstOrDefault();
            if (result == null)
            {
                ui.Print("\nVehicle not found");
            }
            else
            {

                ui.Print("\n" + result.Stats());
            }


        }

        //public void ListVehicleByColor(string color, IUI ui)
        //{
        //    var results = garage.Where(v => v != null && v.Color == color).ToArray();
        //    //return results;
        //    //var v = garage.FindVehicleByColor(color);
        //    if (results.Length == 0)
        //        ui.Print($"\nVehicles with {color} is Not Parked in Garage");
        //    else
        //    {
        //        ui.Print($"\nVehicles with {color} Lists: ");
        //        foreach (var item in results)
        //        {
        //            ui.Print(item.Stats());
        //        }
        //    }
        //}
        //public void ListVehicleByColorAndWheenum(string color, int wheelnum, IUI ui)
        //{
        //    var results = garage.Where(v => v != null && v.Color == color && v.WheelsNum == wheelnum).ToArray();
        //    if (results.Length == 0)
        //        ui.Print($"\nVehicles with {color} color and {wheelnum} no. of wheels is not parked in Garage");
        //    else
        //    {
        //        ui.Print($"\nVehicles with {color} color and wheel numbers {wheelnum}'s Lists: ");
        //        foreach (var item in results)
        //        {
        //            ui.Print(item.Stats());
        //        }
        //    }
        //}


        public void ListVehicleBySpecs(string specs)
        {
            var searchWords = specs.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var results = garage.Select(v => v);

            //try
            //{

                int result;
            foreach (string word in searchWords)
            {
                
                bool success = int.TryParse(word, out result);
                if (!success) { result = -1; }
             
                
                results = garage.Where(v => v.Color == word || 
                                            v.WheelsNum == result
                                            ).ToArray();
                                            
            }
            //}
            //catch (Exception e) { Console.WriteLine(e.Message); }

           
            if (results.Count() == 0)
                Console.WriteLine("not found");
            else
            {

                foreach (var item in results)
                {
                    Console.WriteLine($"{item.Stats()}");
                }
            }
        }

        public void ListAllVehicleWithName(IUI ui, String type)
        {
            var results = garage.Select(v => v);
            if (type == "Car")
                results = garage.Where(v => v is Car);
            else if (type == "Bus")
                results = garage.Where(v => v is Bus);
            else if (type == "Boat")
                results = garage.Where(v => v is Boat);
            else if (type == "Airplane")
                results = garage.Where(v => v is Airplane);
            else if (type == "Motorcyckle")
                results = garage.Where(v => v is Motorcyckle);
            else
            {
                Console.WriteLine($"{type} doesnot exits");
                return;
            }

            results.ToArray();

            if (results.Count() == 0)
                ui.Print($"\nNo {type}'s Parked in the Garage");
            else
            {
                ui.Print($"\n--- {type} List: --- ");
                foreach (var item in results)
                {
                    ui.Print("\n" + item.Stats());

                }
            }
        }

        public void ListAllBus(IUI ui)
        {
            var results = garage.Where(v => v is Bus).ToArray();
            if (results.Length == 0)
                ui.Print("\nNo Bus's Parked in the Garage");
            else
            {
                ui.Print("\n--- Bus Lists: ");
                foreach (var item in results)
                {
                    ui.Print(item.Stats());

                }
            }
        }

        //public void ListAllBoat(IUI ui)
        //{
        //    var results = garage.Where(v => v is Boat).ToArray();
        //    if (results.Length == 0)
        //        ui.Print("\nNo Boat's Parked in the Garage");
        //    else
        //    {
        //        ui.Print("\n--- Boat Lists: ");
        //        foreach (var item in results)
        //        {
        //            ui.Print(item.Stats());

        //        }
        //    }
        //}

        //public void ListAllMotorcyckle(IUI ui)
        //{
        //    var results = garage.Where(v => v is Motorcyckle).ToArray();
        //    if (results.Length == 0)
        //        ui.Print("\nNo Motorcyckle's Parked in the Garage");
        //    else
        //    {
        //        ui.Print("\n--- Motorcyckle Lists: ");
        //        foreach (var item in results)
        //        {
        //            ui.Print(item.Stats());

        //        }
        //    }
        //}

        //public void ListAllAirplane(IUI ui)
        //{
        //    var results = garage.Where(v => v is Airplane).ToArray();
        //    if (results.Length == 0)
        //        ui.Print("\nNo Airplane's Parked in the Garage");
        //    else
        //    {
        //        ui.Print("\n--- Airplane Lists: ");
        //        foreach (var item in results)
        //        {
        //            ui.Print(item.Stats());

        //        }
        //    }
        //}


        public void ListVehicleByLength(double length, IUI ui)
        {
            var results = garage.Where(v => v is Boat b && b.Length >= length).ToArray();
            if (results.Length == 0)
                ui.Print($"\nBoat with Minimum Length: {length} is not parked in the Garage");
            else
            {
                ui.Print($"\nBoat with Minimum Length: {length} Lists: ");
                foreach (var item in results)
                {
                    ui.Print(item.Stats());

                }
            }
            //bool found = false;
            //foreach (var item in garage)
            //{
            //    if (item is Boat b)
            //    {
            //        if (b.Length >= length)
            //        {
            //            found = true;
            //            Console.WriteLine(b.Stats());
            //        }
            //    }

            //}
            //if (!found)
            //{
            //    { Console.WriteLine("Boat does not exist"); }
            //}

        }

        public void EmptyGarage(IUI ui)
        {
            garage.EmptyGarage();
            ui.Print("All the Vehicles are Removed from the Garage");
        }
    }
}
