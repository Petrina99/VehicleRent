// See https://aka.ms/new-console-template for more information
using VehicleRent;

VehicleManager vManager = new VehicleManager();

Car car = new Car("BMW", "M5", 2022, 450, "Sports car", 4395, 10000, "Diesel");

vManager.AddMoto();
vManager.ListAll();
/*
int a;
do
{
    Console.WriteLine("Odaberite jednu od opcija: ");
    Console.WriteLine("#1: Add a car");
    Console.WriteLine("#12: Add a motorcycle");
    Console.WriteLine("#2: Delete a vehicle");
    Console.WriteLine("#3: List all vehicles");
    Console.WriteLine("#4: List all vehicles (summary)");
    Console.WriteLine("#5: List all cars");
    Console.WriteLine("#6: List all trucks");
    Console.WriteLine("#7: List all motorcycles");
    Console.WriteLine("#9: Exit program");

    a = Int32.TryParse(Console.ReadLine(), out a) ? a : 0;
}
while (a != 1);*/
