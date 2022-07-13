namespace FactoryDP.Vehicles
{
    public class Car : IVehicle
    {
        public string Name { get; private set; }
        public int Year { get; private set; }
        public int Doors { get; private set; }
        public string Color { get; private set; }

        public Car(string name, int year, int doors, string color)
        {
            Name = name;
            Year = year;
            Doors = doors;
            Color = color;
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Viagem iniciada");
        }

        public override string ToString()
        {
            return $"Seu carro: {Name}, {Year}, {Color}";
        }
    }
}
