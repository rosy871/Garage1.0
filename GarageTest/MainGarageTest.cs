using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage1._0;


namespace GarageTest
{
    [TestClass]
    public class MainGarageTest
    {

        [TestMethod]
        public void Constructor_NegativeCapacity_Returns_1()
        {
            //Arrange
            int expected = 1;
            const int capacity = -10;

            //Act
           Garage<Vehicle> garage1 = new Garage<Vehicle>(capacity);
            //Assert
            Assert.AreEqual(garage1.Capacity, expected);
        }

        [TestMethod]
        public void AddVehicle_AddElement_void()
        {
            //Arrange

            const int capacity = 2;

            //Act
           Garage<Vehicle> garage = new Garage<Vehicle>(capacity);

            string name = "audi";
            string regnum = "abc123";
            string color = "red";
            int wheelnum = 4;
            var veh = new Vehicle(name, regnum, color, wheelnum);

            garage.AddVehicle(veh);

            string name2 = "audi";
            string regnum2 = "xyz456";
            string color2 = "red";
            int wheelnum2 = 4;
            var veh2 = new Vehicle(name2, regnum2, color2, wheelnum2);

            garage.AddVehicle(veh2);


            //Assert
            //Assert.AreEqual(garage1.Capacity, expected);
        }

        [TestMethod]
        public void RemoveVehicle_AddElement_ReturnsRemovedVehicle()
        {
            //Arrange

            const int capacity = 2;

            //Act
           Garage<Vehicle> garage = new Garage<Vehicle>(capacity);

            string name = "audi";
            string regnum = "abc123";
            string color = "red";
            int wheelnum = 4;
            var veh = new Vehicle(name, regnum, color, wheelnum);

            garage.AddVehicle(veh);

            string name2 = "audi";
            string regnum2 = "xyz456";
            string color2 = "red";
            int wheelnum2 = 4;
            var veh2 = new Vehicle(name2, regnum2, color2, wheelnum2);

            garage.AddVehicle(veh2);

            var removeVeh = garage.RemoveVehicle(regnum2);

            //Assert
            Assert.AreEqual(removeVeh, veh2);

            string notExistingRegNum = "aab993";
            var removeIncorectVeh = garage.RemoveVehicle(notExistingRegNum);
            Assert.AreEqual(removeIncorectVeh, null);
        }


        [TestMethod]
        public void IsFull_CheckVehicleArray_ReturnsTrueOrFalse()
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(2);

            string name = "audi";
            string regnum = "abc123";
            string color = "red";
            int wheelnum = 4;
            var veh = new Vehicle(name, regnum, color, wheelnum);

            garage.AddVehicle(veh);

            string name2 = "audi";
            string regnum2 = "xyz456";
            string color2 = "red";
            int wheelnum2 = 4;
            var veh2 = new Vehicle(name2, regnum2, color2, wheelnum2);

            garage.AddVehicle(veh2);

            Assert.IsTrue(garage.IsFull);
        }

        [TestMethod]
        public void IsEmpty_CheckVehicleArray_ReturnsTrueOrFalse()
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(2);

            bool emptyArray = garage.IsEmpty;
            Assert.IsTrue(emptyArray);

            string name = "audi";
            string regnum = "abc123";
            string color = "red";
            int wheelnum = 4;
            var veh = new Vehicle(name, regnum, color, wheelnum);

            garage.AddVehicle(veh);
            Assert.IsFalse(garage.IsEmpty);

        }
    }
}
