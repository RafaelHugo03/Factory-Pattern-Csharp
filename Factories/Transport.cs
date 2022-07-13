using FactoryDP.Vehicles;

namespace FactoryDP.Factories
{
    public abstract class Transport
    {
        public void StartTransport() 
        {
            IVehicle vehicle = CreateTransport();
            vehicle.StartRoute();
        }

        public abstract IVehicle CreateTransport();
    }
}
