using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class VehicleUI
    {
        
        public void ParkVehicleinGarage(IGarageHandlar gh)
        {
            while (true)
            {
                if (gh.GarageIsFull())
                {
                    Console.WriteLine("\nGarage is Full");
                    return;
                }
                string name, reg, color;
                int wheelnum;
                Console.WriteLine("\nPress 1 for Parking Car\n"
                    + "Press 2 for Parking Buss\n"
                    + "Press 3 for parking Boat\n"
                    + "Press 4 for parking Aeroplane\n"
                    + "Press 5 for parking motorbike\n"
                    + "press 0 for exit"
                    );
                try
                {
                    switch (Console.ReadLine())
                    {
                        case "1":

                            VehicleCommonSpecification(out name, out reg, out color, out wheelnum);

                            Console.Write("Fuel Type:  ");
                            string fuel = Console.ReadLine();

                            Car c = new Car(name, reg, color, wheelnum, fuel);
                            gh.ParkVehicleinGarage(c);

                            break;

                        case "2":
                            VehicleCommonSpecification(out name, out reg, out color, out wheelnum);
                            Console.Write("Number of seats:  ");
                            int seatnum = int.Parse(Console.ReadLine());

                            Bus b = new Bus(name, reg, color, wheelnum, seatnum);
                            gh.ParkVehicleinGarage(b);
                            break;

                        case "3":
                            VehicleCommonSpecification(out name, out reg, out color, out wheelnum);
                            Console.Write("Length of Boat:  ");
                            double length = double.Parse(Console.ReadLine());

                            Boat bt = new Boat(name, reg, color, wheelnum, length);
                            gh.ParkVehicleinGarage(bt);
                            break;

                        case "4":
                            VehicleCommonSpecification(out name, out reg, out color, out wheelnum);
                            Console.Write("Number of Engines:  ");
                            int enginenum = int.Parse(Console.ReadLine());

                            Boat ap = new Boat(name, reg, color, wheelnum, enginenum);
                            gh.ParkVehicleinGarage(ap);

                            break;
                        case "5":

                            VehicleCommonSpecification(out name, out reg, out color, out wheelnum);
                            Console.Write("Number of Engines:  ");
                            int cc = int.Parse(Console.ReadLine());

                            Motorcyckle mc = new Motorcyckle(name, reg, color, wheelnum, cc);
                            gh.ParkVehicleinGarage(mc);

                            break;
                        case "0":
                            return;
                        // break;


                        default:
                            Console.WriteLine("fel input press(1,2,3,4)");
                            break;
                    }
                }catch(Exception e)
                { Console.WriteLine(e.Message); }
            }
        }

        private static void VehicleCommonSpecification(out string name, out string reg, out string color, out int wheelnum)
        {
            Console.Write("Brand/Type:  ");
            name = Console.ReadLine();
            Console.Write("Registration Number:  ");
            reg = Console.ReadLine();
            Console.Write("Color:  ");
            color = Console.ReadLine();
            Console.Write("Number of wheel:  ");
            wheelnum = int.Parse(Console.ReadLine());
        }

       public void ShowVehicleWithColorAndWheel(IGarageHandlar gh)
        {
            if (gh.GarageIsEmpty())
            {
                Console.WriteLine("\nGarage is Empty.");
                return;
            }

            Console.WriteLine("Enter Color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter Number of Wheels");
            int wheelnum = int.Parse(Console.ReadLine());

            gh.ListVehicleByColorAndWheenum(color, wheelnum);
        }

        public void ShowVehiclesWithColor(IGarageHandlar gh)
        {
            if (gh.GarageIsEmpty())
            {
                Console.WriteLine("\nGarage is Empty.");
                return;
            }

            Console.WriteLine("Enter Color");
            string color = Console.ReadLine();
            gh.ListVehicleByColor(color);

        }

       public void RemoveVechicleFromGarage(IGarageHandlar gh)
        {
            if (gh.GarageIsEmpty())
            {
                Console.WriteLine("\nGarage is Empty.");
                return;
            }

            Console.WriteLine("Enter Vehicle Reg num.");
            string regnum = Console.ReadLine();
            gh.RemoveVehiclefromGarage(regnum);

        }
       
    }
}
