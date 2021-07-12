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
        public void Constructor_NegativeCapacity_Returns1()
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

            var veh1 = new Car("Audi", "AUD123", "red", 4, "diesel");
            var veh2 = new Car("Audi", "AUD456", "red", 4, "Patrol");


            garage.AddVehicle(veh1);
            garage.AddVehicle(veh2);

            Assert.IsNotNull(garage);





            //Assert
            //Assert.AreEqual(garage1.Capacity, expected);
        }

        [TestMethod]
        public void RemoveVehicle_AddElement_ReturnsRemovedVehicle()
        {
            //Arrange

            const int capacity = 2;

            Garage<Vehicle> garage = new Garage<Vehicle>(capacity);

            var veh1 = new Car("Audi", "AUD123", "red", 4, "diesel");
            var veh2 = new Car("Audi", "AUD456", "red", 4, "Patrol");
            garage.AddVehicle(veh1);
            garage.AddVehicle(veh2);

            //Act
            var removeVeh = garage.RemoveVehicle("AUD123");

            //Assert
            Assert.AreEqual(veh1, removeVeh);

            string notExistingRegNum = "aab993";
            var removeIncorectVeh = garage.RemoveVehicle(notExistingRegNum);
            Assert.AreEqual(null, removeIncorectVeh);
        }


        [TestMethod]
        public void IsFull_CheckVehicleArray_ReturnsTrueOrFalse()
        {

            Garage<Vehicle> garage = new Garage<Vehicle>(2);

            var veh1 = new Bus("schoolbus", "AUD123", "red", 4, 22);
            var veh2 = new Car("Audi", "AUD456", "red", 4, "Patrol");

            garage.AddVehicle(veh1);
            garage.AddVehicle(veh2);

            Assert.IsTrue(garage.IsFull);
        }

        [TestMethod]
        public void IsEmpty_CheckVehicleArray_ReturnsTrueOrFalse()
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(2);

            Assert.IsTrue(garage.IsEmpty);

            var veh1 = new Motorcyckle("Honda", "hon111", "black", 1, 120);

            garage.AddVehicle(veh1);
            Assert.IsFalse(garage.IsEmpty);

        }
    }
}
