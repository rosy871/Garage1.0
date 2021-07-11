using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections;

namespace Garage1._0
{
    public interface IGarage<T> : IEnumerable<T>  where T : Vehicle
    {
        int Capacity { get; set; }
        bool IsEmpty { get; }
        bool IsFull { get; }

       // void initializeVehicleArr(int cap);
        public void AddVehicle(IVehicle veh);
        void EmptyGarage();
        new IEnumerator<T> GetEnumerator();
        IVehicle RemoveVehicle(string regNum);

         public bool IsFull2();
    }
}