using FactoryDP.Vehicles;

namespace FactoryDP.Factories
{
    public class BikeTransport : Transport
    {
        public string Color { get; private set; }

        public BikeTransport(string color)
        {
            Color = color;
        }

        public override IVehicle CreateTransport()
        {
            var bike = new Bike(Color);
            Console.WriteLine(bike);
            return bike;
        }
    }
}
