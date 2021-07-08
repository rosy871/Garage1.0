namespace Garage1._0
{
    interface IVehicle
    {
        public string RegisterNum { get; }
        public string Color { get; }
        public int WheelsNum { get; }
        public string Name { get; }
        public string Stats();
    }
}