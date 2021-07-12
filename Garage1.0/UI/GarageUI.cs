using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    public class GarageUI
    {
        VehicleUI vui = new VehicleUI();
        IGarageHandlar gh;
        IUI ui;

        public GarageUI(IGarageHandlar ghObj, IUI uiobj)
        {
            gh = ghObj;
            ui = uiobj;
        }

        public void StartProj()
        {
            Console.WriteLine("testing for readline");
            while (true)
            {

                ui.Print("\nGarage Main menu\nPlease navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 6 7,,0) of your choice"
                    + "\n1.  List all the parked vehicles."
                    + "\n2.  Park vehicle in Garage."
                    + "\n3.  Remove Vehicle from the Garage."
                    + "\n4.  List all the Parked Vehicle with Color"
                    + "\n5.  List all the Parked Vechicle with Color and Wheels number "
                    + "\n6.  List all the Boat whose length is greater or equal to provided length"
                    + "\n7.  List all Car "
                    + "\n8.  List all Bus"
                    + "\n9.  List all Boat"
                    + "\n10. List all Motorcyckle "
                    + "\n11. List all Airplane"
                    + "\n12. Remove all the Parked Vehicles from the Garage "
                    + "\n0.  Exit the application");



                switch (ui.GetInput())
                {
                    case "1":
                        gh.ListAllVehicle(ui);
                        break;
                    case "2":
                        vui.ParkVehicleinGarage(gh, ui);

                        break;
                    case "3":
                        vui.RemoveVechicleFromGarage(gh, ui);
                        break;

                    case "4":
                        vui.ShowVehiclesWithColor(gh, ui);
                        break;

                    case "5":
                        vui.ShowVehicleWithColorAndWheel(gh, ui);
                        break;

                    case "6":
                        vui.ListVehicleByLength(gh, ui);

                        break;

                    case "7":
                        gh.ListAllCars(ui);
                        break;

                    case "8":
                        gh.ListAllBus(ui);
                        break;

                    case "9":
                        gh.ListAllBoat(ui);
                        break;

                    case "10":
                        gh.ListAllMotorcyckle(ui);
                        break;

                    case "11":
                        gh.ListAllAirplane(ui);
                        break;

                    case "12":
                        gh.EmptyGarage(ui);
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        ui.Print("Please Enter some Valid Input (0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)\n");
                        break;
                }

                Console.ReadKey();

            }
        }


    }
}
