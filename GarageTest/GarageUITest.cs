using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Garage1._0;

namespace GarageTest
{
    [TestClass]
    public class GarageUITest
    {
        private GarageUI ui;
        private Mock<IGarageHandlar> gMock;

        [TestMethod]
        public void StartProj_boolchk_returnfalse()
        {
            //problem in read line
            gMock = new Mock<IGarageHandlar>();

            string name1 = "audi";
            string regnum1 = "jjp122";
            string color1 = "red";
            int wheelnum1 = 4;
            var veh1 = new Garage1._0.Vehicle(name1, regnum1, color1, wheelnum1);
            gMock.Setup(g => g.ParkVehicleinGarage(veh1));
            ui = new GarageUI(gMock.Object);

            ui.StartProj();

            gMock.Verify(g => g.ListAllVehicle());
        }
    }
}
