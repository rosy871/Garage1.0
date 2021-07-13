using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage1._0;

namespace GarageTest
{
    [TestClass]
    public class GarageHandlarTest
    {

        GarageHandlar gh = new GarageHandlar();
        IUI ui = new ConsoleUI();

        [TestMethod]
        public void GarageIsEmpty_chekfunctions_returnTruefalse()
        {

            var veh1 = new Car("Audi", "AUD123", "red", 4, "diesel");
            Assert.IsTrue(gh.GarageIsEmpty());

            gh.ParkVehicleinGarage(veh1, ui);
            Assert.IsFalse(gh.GarageIsEmpty());

        }

        [TestMethod]
        public void GarageIsFull_check_returnsTrueFalse()
        {


            Assert.IsFalse(gh.GarageIsFull());

            var veh1 = new Car("Audi", "AUD123", "red", 4, "diesel");
            var veh2 = new Car("Audi", "AUD456", "red", 4, "Patrol");
            var veh3 = new Boat("yatch", "yat123", "white", 0, 12);
            var veh4 = new Boat("Cuise", "boa122", "white", 0, 40);
            var veh5 = new Bus("schoolbus", "sch111", "ywllow", 4, 22);
            gh.ParkVehicleinGarage(veh1, ui);
            gh.ParkVehicleinGarage(veh2, ui);
            gh.ParkVehicleinGarage(veh3, ui);
            gh.ParkVehicleinGarage(veh4, ui);
            gh.ParkVehicleinGarage(veh5, ui);
            Assert.IsTrue(gh.GarageIsFull());

            //gh.ListAllVehicle(ui);

            //gh.RemoveVehiclefromGarage("aud123", ui);
            //gh.RemoveVehiclefromGarage("air999", ui);//non exixtent regnum

           
            //gh.ListAllVehicleWithName(ui, "Boat");
           

          
            //gh.ListVehicleByLength(5, ui);

        }

       
        }

}








