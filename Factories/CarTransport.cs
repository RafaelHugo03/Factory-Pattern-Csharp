using FactoryDP.Vehicles;

namespace FactoryDP.Factories
{
    public class CarTransport : Transport
    {
        public string Name { get; private set; }
        public int Year { get; private set; }
        public int Doors { get; private set; }
        public string Color { get; private set; }

        public CarTransport(string name, int year, int doors, string color)
        {
            Name = name;
            Year = year;
            Doors = doors;
            Color = color;
        }

        public override IVehicle CreateTransport()
        {
            var car = new Car(Name, Year, Doors, Color);   
            Console.WriteLine(car);
            return car; 
        }
    }
}
