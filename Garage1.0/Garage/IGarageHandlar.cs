namespace Garage1._0
{
    public interface IGarageHandlar
    {
        public bool GarageIsFull();
        public bool GarageIsEmpty();

        public void FindVehicleinGarage(string regnum);
        public void ListAllVehicle();
        public void ListVehicleByColor(string color);
        public void ListVehicleByColorAndWheenum(string color, int wheelnum);
        void ParkVehicleinGarage(Vehicle v);
        public void RemoveVehiclefromGarage(string regNumber);
        public void EmptyGarage();
        public void ListVehicleByLength(double lenght);
    }
}