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
           // Console.WriteLine("testing for readline");
            while (true)
            {

                ui.Print("\nGarage Main menu\nPlease navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 6 7,,0) of your choice"
                    + "\n1.  List all the parked vehicles."
                    + "\n2.  Park vehicle in Garage."
                    + "\n3.  Remove Vehicle from the Garage."
                    + "\n4.  List all the Parked Vehicle with Vehicle Specification for ex color or wheelnum or both."
                    + "\n5.  List all the Boat whose length is greater or equal to provided length"
                    + "\n6.  List all Car or Bus or Boat or Motorcyckle or Airplane "
                    + "\n7.  Remove all the Parked Vehicles from the Garage "
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
                        vui.ShowVehiclesWithSpecs(gh,ui);
                        break;


                    case "5":
                        vui.ListVehicleByLength(gh, ui);

                        break;

                    case "6":
                        vui.ListAllVehicleWithName(gh,ui);
                        break;

                  
                    case "7":
                        gh.EmptyGarage(ui);
                        break;

                    case "0":
                        ui.Print("Exiting from main menu....\n\n");
                        Environment.Exit(0);
                        break;
                    default:
                        ui.Print("Please Enter some Valid Input (0, 1, 2, 3, 4, 5, 6, 7)\n");
                        break;
                }

               

            }
        }


    }
}
