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

        [TestMethod]
        public void GarageIsfull_boolchk_returnfalse()
        {
            Assert.AreEqual(false, gh.GarageIsFull());
            Assert.AreEqual(true, gh.GarageIsEmpty());

            string name1 = "audi";
            string regnum1 = "jjp122";
            string color1 = "red";
            int wheelnum1 = 4;
            var veh1 = new Garage1._0.Vehicle(name1, regnum1, color1, wheelnum1);

            gh.ParkVehicleinGarage(veh1);
            Assert.AreEqual(false, gh.GarageIsEmpty());

            string name2 = "audi";
            string regnum2 = "abc123";
            string color2 = "red";
            int wheelnum2 = 4;
            var veh2 = new Garage1._0.Vehicle(name2, regnum2, color2, wheelnum2);

            gh.ParkVehicleinGarage(veh2);
            gh.RemoveVehiclefromGarage("xyx131");
            gh.RemoveVehiclefromGarage(regnum2);
            gh.FindVehicleinGarage(regnum2);
            gh.ListAllVehicle();
            gh.ListVehicleByColor(color1);
            gh.ListVehicleByColorAndWheenum(color1, 4);


            gh.ListVehicleByLength(12);
            string name3 = "Titanic";
            string regnum3 = "ttX213";
            string color3 = "White";
            int wheelnum3 = 0;
            int length3 = 300;
            var veh3 = new Garage1._0.Boat(name3, regnum3, color3, wheelnum3, length3);
            gh.ParkVehicleinGarage(veh3);
            gh.ListVehicleByLength(200);

            string name4 = "peugeot";
            string regnum4 = "adn675";
            string color4 = "red";
            int wheelnum4 = 4;
            var veh4 = new Garage1._0.Vehicle(name4, regnum4, color4, wheelnum4);

            gh.ParkVehicleinGarage(veh4);

            string name5 = "volvo";
            string regnum5 = "mtp986";
            string color5 = "blue";
            int wheelnum5 = 4;
            var veh5 = new Garage1._0.Vehicle(name5, regnum5, color5, wheelnum5);

            gh.ParkVehicleinGarage(veh5);

            gh.ParkVehicleinGarage(veh2);

            string name6 = "audi";
            string regnum6 = "jjp122";
            string color6 = "red";
            int wheelnum6 = 4;
            var veh6 = new Garage1._0.Vehicle(name6, regnum6, color6, wheelnum6);

            gh.ParkVehicleinGarage(veh6);
            Assert.AreEqual(true, gh.GarageIsFull());

            gh.EmptyGarage();
            Assert.AreEqual(true, gh.GarageIsEmpty());
        }
    }
}
