namespace Garage1._0
{
    interface IGarageHandlar
    {
        bool GarageIsFull();
        bool GarageIsEmpty();

        void FindVehicleinGarage(string regnum);
        void ListAllVehicle();
        void ListVehicleByColor(string color);
        void ListVehicleByColorAndWheenum(string color, int wheelnum);
        void ParkVehicleinGarage(Vehicle v);
        void RemoveVehiclefromGarage(string regNumber);
        void EmptyGarage();
    }
}