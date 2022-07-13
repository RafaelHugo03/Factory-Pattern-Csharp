using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP.Vehicles
{
    public class Bike : IVehicle
    {
        public string Color { get; private set; }

        public Bike(string color)
        {
            Color = color;
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            Console.WriteLine("Iniciamos as entregas, pode demorar um pouco pois entregamos com bicicletas");
        }
        public override string ToString()
        {
            return $"Cor da bicicleta: {Color}";
        }
    }
}
