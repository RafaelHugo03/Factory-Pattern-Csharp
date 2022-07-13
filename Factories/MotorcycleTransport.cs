using FactoryDP.Vehicles;

namespace FactoryDP.Factories
{
    public class MotorcycleTransport : Transport
    {
        public string Name { get; private set; }
        public int Year { get; private set; }
        public double Engine { get; private set; }
        public string Color { get; private set; }

        public MotorcycleTransport(string name, int year, double engine, string color)
        {
            Name = name;
            Year = year;
            Engine = engine;
            Color = color;
        }

        public override IVehicle CreateTransport()
        {
            var motorcycle = new Motorcycle(Name, Year, Engine, Color);   
            Console.WriteLine(motorcycle);  
            return motorcycle;
        }
    }
}
