namespace Garage1._0
{
    public interface IGarageHandlar
    {
        public bool GarageIsFull();
        public bool GarageIsEmpty();

        public void FindVehicleinGarage(string regnum, IUI ui);
        public void ListAllVehicle(IUI ui);
        //public void ListVehicleByColor(string color, IUI ui);
        //public void ListVehicleByColorAndWheenum(string color, int wheelnum, IUI ui);
        void ParkVehicleinGarage(Vehicle v, IUI ui);
        public void RemoveVehiclefromGarage(string regNumber, IUI ui);
        public void EmptyGarage(IUI ui);
        public void ListVehicleByLength(double lenght, IUI ui);
        public void ListAllVehicleWithName(IUI ui, string str);
        //public void ListAllBus(IUI ui);
        //public void ListAllBoat(IUI ui);
        //public void ListAllMotorcyckle(IUI ui);
        //public void ListAllAirplane(IUI ui);
        public void ListVehicleBySpecs(string specs);


    }
}