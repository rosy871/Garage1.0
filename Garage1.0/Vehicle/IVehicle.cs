namespace Garage1._0
{
    interface IVehicle
    {
        string Color { get; }
        string Name { get; }
        string RegisterNum { get; }
        int WheelsNum { get; }

        public string Stats();
            }
}