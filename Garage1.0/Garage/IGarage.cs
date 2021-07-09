using System.Collections.Generic;

namespace Garage1._0
{
    public interface IGarage<T> where T : Vehicle
    {
        int Capacity { get; set; }
        virtual bool IsEmpty { get; }
        bool IsFull { get; }

        void AddVehicle(Vehicle veh);
        void EmptyGarage();
        IEnumerator<T> GetEnumerator();
        Vehicle RemoveVehicle(string regNum);

        
    }
}