using System;

namespace Garage1._0
{

    class Program
    {
        static IGarageHandlar gh = new GarageHandlar();

        static void Main(string[] args)
        {
            IUI ui = new GarageUI();
            ui.StartProj();
           


            //Car c=new Car("car","qwe","black",4,"deisel");
            //Car c1=new Car("car","awe","black",4,"petrol");
            //Boat b = new Boat("Boat", "123", "white", 0, 10);
            //Bus b1 = new Bus("SchoolBus", "1234", "yellow", 4, 20);
            //Bus b2 = new Bus("Bus", "124", "red", 4, 26);

            ////var gar = new Garage<Vehicle>(10);

            //GarageHandlar gh = new GarageHandlar();
            //gh.ParkVehicleinGarage(c);
            //gh.ParkVehicleinGarage(c1);
            //gh.ParkVehicleinGarage(b);
            //gh.ParkVehicleinGarage(b1);
            //gh.ParkVehicleinGarage(b2);
            //Console.WriteLine("-------------");
            //gh.ListAllVehicle();
            //Console.WriteLine("-------------");
            //gh.FindVehicleinGarage("qwe");
            //Console.WriteLine("-------------");
            //gh.ListVehicleByColor("black");
            //gh.ListVehicleByColor("white");
            //Console.WriteLine("-----------------");
            //gh.ListVehicleByColorAndWheenum("white", 4);

            //Console.WriteLine("-----------------");
            //gh.RemoveVehiclefromGarage("12233");

            //Vehicle[] vehicles = new Vehicle[5];
            //vehicles[0] = c;
            //vehicles[1] = c1;
            //vehicles[2] = b;
            //vehicles[3] = b1;
            //vehicles[4] = b2;

            //foreach (var item in vehicles)
            //{
            //    Console.WriteLine(item.Stats());
            //}

            //Garage<Vehicle> gar1 = new Garage<Vehicle>(5);
            //gar1.AddVehicle(c);
            //gar1.AddVehicle(b1);
            //gar1.AddVehicle(b);
            //gar1.AddVehicle(c1);
            //gar1.AddVehicle(b2);


            //gar1.showParkedVehicle();
        }

      

       

       
    }
}
