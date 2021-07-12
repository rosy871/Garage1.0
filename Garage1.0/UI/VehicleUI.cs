using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class VehicleUI
    {

        public void ParkVehicleinGarage(IGarageHandlar gh, IUI ui)
        {
            while (true)
            {
                if (gh.GarageIsFull())
                {
                    ui.Print("\nGarage is Full");
                    return;
                }
                string name, reg, color;
                int wheelnum;
                ui.Print("\nPress 1 for Parking Car\n"
                    + "Press 2 for Parking Buss\n"
                    + "Press 3 for parking Boat\n"
                    + "Press 4 for parking Aeroplane\n"
                    + "Press 5 for parking motorbike\n"
                    + "press 0 for exit"
                    );
                try
                {
                    switch (ui.GetInput())
                    {
                        case "1":

                            VehicleCommonSpecification(out name, out reg, out color, out wheelnum, ui);

                            ui.PrintSL("Fuel Type:  ");
                            string fuel = ui.GetInput();

                            Car c = new Car(name, reg, color, wheelnum, fuel);
                            gh.ParkVehicleinGarage(c, ui);

                            break;

                        case "2":
                            VehicleCommonSpecification(out name, out reg, out color, out wheelnum, ui);
                            ui.PrintSL("Number of seats:  ");
                            int seatnum = int.Parse(ui.GetInput());

                            Bus b = new Bus(name, reg, color, wheelnum, seatnum);
                            gh.ParkVehicleinGarage(b, ui);
                            break;

                        case "3":
                            VehicleCommonSpecification(out name, out reg, out color, out wheelnum, ui);
                            ui.PrintSL("Length of Boat:  ");
                            double length = double.Parse(ui.GetInput());

                            Boat bt = new Boat(name, reg, color, wheelnum, length);
                            gh.ParkVehicleinGarage(bt, ui);
                            break;

                        case "4":
                            VehicleCommonSpecification(out name, out reg, out color, out wheelnum, ui);
                            ui.PrintSL("Number of Engines:  ");
                            int enginenum = int.Parse(ui.GetInput());

                            Airplane ap = new Airplane(name, reg, color, wheelnum, enginenum);
                            gh.ParkVehicleinGarage(ap, ui);

                            break;
                        case "5":

                            VehicleCommonSpecification(out name, out reg, out color, out wheelnum, ui);
                            ui.PrintSL("Cylinder Capacity:  ");
                            int cc = int.Parse(ui.GetInput());

                            Motorcyckle mc = new Motorcyckle(name, reg, color, wheelnum, cc);
                            gh.ParkVehicleinGarage(mc, ui);

                            break;
                        case "0":
                            return;
                        // break;


                        default:
                            ui.Print("fel input press(1,2,3,4)");
                            break;
                    }
                }
                catch (Exception e)
                { ui.Print(e.Message); }
            }
        }


        private static void VehicleCommonSpecification(out string name, out string reg, out string color, out int wheelnum, IUI ui)
        {
            ui.PrintSL("Brand/Type:  ");
            name = ui.GetInput();

            ui.PrintSL("Registration Number:  ");
            reg = ui.GetInput().ToUpper();


            ui.PrintSL("Color:  ");
            color = ui.GetInput();

            ui.PrintSL("Number of wheel:  ");
            wheelnum = int.Parse(ui.GetInput());
        }

        public void ListVehicleByLength(IGarageHandlar gh, IUI ui)
        {
            if (gh.GarageIsEmpty())
            {
                ui.Print("\nGarage is Empty.\n");
                return;
            }

            ui.Print("Enter Minimum Length:  ");
            double length = int.Parse(ui.GetInput());
            gh.ListVehicleByLength(length, ui);
        }

        public void ShowVehicleWithColorAndWheel(IGarageHandlar gh, IUI ui)
        {
            if (gh.GarageIsEmpty())
            {
                ui.Print("\nGarage is Empty.");
                return;
            }

            ui.PrintSL("Enter Color:  ");
            string color = ui.GetInput();
            ui.PrintSL("Enter Number of Wheels:  ");
            int wheelnum = int.Parse(ui.GetInput());

            gh.ListVehicleByColorAndWheenum(color, wheelnum, ui);
        }

        public void ShowVehiclesWithColor(IGarageHandlar gh, IUI ui)
        {
            if (gh.GarageIsEmpty())
            {
                ui.Print("\nGarage is Empty.");
                return;
            }

            ui.PrintSL("Enter Color:  ");
            string color = ui.GetInput();
            gh.ListVehicleByColor(color, ui);

        }

        public void RemoveVechicleFromGarage(IGarageHandlar gh, IUI ui)
        {
            if (gh.GarageIsEmpty())
            {
                ui.Print("\nGarage is Empty.");
                return;
            }

            ui.PrintSL("Enter Vehicle Reg num:  ");
            string regnum = ui.GetInput().ToUpper();

            gh.RemoveVehiclefromGarage(regnum, ui);

        }

    }
}
