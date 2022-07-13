// See https://aka.ms/new-console-template for more information
using FactoryDP.Factories;
Menu();

Transport transport;
void Menu() 
{
    Console.Write("O que deseja, 1 - para uber, 2 - para entregas rápidas, 3 - para entregas normais, 0 - para sair: ");
    var option = int.Parse(Console.ReadLine().ToLower());

    switch (option)
    {
        case 1: Car(); break;
        case 2: Motorcycle(); break;
        case 3: Bike(); break;
        case 0: Console.WriteLine("Finalizando programa...");break;
        default: Console.WriteLine("Opção... Tente novamente"); Menu(); break;
    }
}
void Bike() 
{
    transport = new BikeTransport("vermelha");
    transport.StartTransport();
    Console.WriteLine("Pressione qualquer tecla para voltar ao Menu");
    Console.ReadKey();
    Menu();
}
void Car() 
{
    transport = new CarTransport("Civic", 2020, 4, "Preto");
    transport.StartTransport();
    Console.WriteLine("Pressione qualquer tecla para voltar ao Menu");
    Console.ReadKey();
    Menu();
}
void Motorcycle()
{
    transport = new MotorcycleTransport("Fazer", 2022, 250, "Vermelha");
    transport.StartTransport();
    Console.WriteLine("Pressione qualquer tecla para voltar ao Menu");
    Console.ReadKey();
    Menu();
}