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
    public class VehicleTest
    {
        [TestMethod]
        public void Stats_CreatObj_PrintStats()
        {
            string name = "audi";
            string regnum = "abc123";
            string color = "red";
            int wheelnum = 4;
            string fuel = "deisel";
            var vechile = new Car(name, regnum, color, wheelnum,fuel);
            string actual = vechile.Stats();
           
            string expected = $"Name : {name,-11} Register Number : {regnum,-10} color : {color,-10} No. of Wheels : {wheelnum,-5} FuelType : {fuel,10}";
            string notexpcted = "blablabla";

            Assert.AreEqual(expected, actual);
            Assert.AreNotEqual(notexpcted, actual);

        }
    }
}
