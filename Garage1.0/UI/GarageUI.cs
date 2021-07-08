﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class GarageUI : IUI
    {
        VehicleUI vui = new VehicleUI();
        IGarageHandlar gh = new GarageHandlar();
        public void StartProj()
        {
            while (true)
            {
                //Console.Clear();

                Console.WriteLine("\nGarage Main menu\nPlease navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 6 7,,0) of your choice"
                    + "\n1. List all the parked vehicles."
                    + "\n2. Park vehicle in Garage."
                    + "\n3. Remove Vehicle from the Garage."
                    + "\n4. List all the Parked Vehicle with Color"
                    + "\n5. List all the Parked Vechicle with Color and Wheels number "
                    + "\n6. Remove all the Parked Vehicles from the Garage"
                    + "\n7. List all the Boat whose length is greater or equal to provided length "
                    + "\n0. Exit the application");

                switch (Console.ReadLine())
                {
                    case "1":
                        gh.ListAllVehicle();
                        break;
                    case "2":
                        vui.ParkVehicleinGarage(gh);

                        break;
                    case "3":
                        vui.RemoveVechicleFromGarage(gh);
                        break;

                    case "4":
                        vui.ShowVehiclesWithColor(gh);
                        break;

                    case "5":
                        vui.ShowVehicleWithColorAndWheel(gh);
                        break;

                    case "6":
                        gh.EmptyGarage();
                        Console.WriteLine("All the Vehicles are Removed from the Garage");
                        break;

                    case "7":
                        gh.ListVehicleByLength(22);
                        break;


                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Enter some Valid Input (0, 1, 2, 3, 4, 5, 6, 7)");
                        break;
                }
                //Console.ReadKey();

            }
        }


    }
}