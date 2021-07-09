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

        // Mock<GarageHandlar> mock = new Mock<GarageHandlar>();
        private Mock<Garage<Vehicle>> garageMock;

        


        [TestMethod]
        public void GarageIsfull_boolchk_returnfalse()
        {
            IGarageHandlar gh = new GarageHandlar();
            garageMock = new Mock<Garage<Vehicle>>();

            //garageMock.SetupGet(m => m.Capacity).Returns(5);
            //garageMock.Verify(t => t.Capacity);

            garageMock.Setup(m => m.IsFull).Returns(false);
            garageMock.Verify(func => func.IsFull);


            var isEmpty =  gh.GarageIsEmpty();
            
            //bool expected = false;
            //mock.Setup(m => m.GarageIsFull()).Returns(expected);
             
            

        }
    }
}
