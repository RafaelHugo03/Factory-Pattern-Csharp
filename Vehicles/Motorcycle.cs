namespace FactoryDP.Vehicles
{
    public class Motorcycle : IVehicle
    {
        public string Name { get; private set; }
        public int Year { get; private set; }
        public double Engine { get; private set; }
        public string Color { get; private set; }

        public Motorcycle(string name, int year, double engine, string color)
        {
            Name = name;
            Year = year;
            Engine = engine;
            Color = color;
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a entrega");
        }
        public override string ToString()
        {
            return $"Moto do entregador: {Name}, {Color}";
        }
    }
}
