// See https://aka.ms/new-console-template for more information
using VehicleRent;

VehicleManager vManager = new VehicleManager();

int a;
do
{
    Console.WriteLine("Odaberite jednu od opcija: ");
    Console.WriteLine("#1:  Add a car");
    Console.WriteLine("#12: Add a motorcycle");
    Console.WriteLine("#2:  Delete a vehicle");
    Console.WriteLine("#3:  List all vehicles");
    Console.WriteLine("#4:  List all vehicles (summary)");
    Console.WriteLine("#5:  Edit vehicle");
    Console.WriteLine("#9:  Exit program");

    a = Int32.TryParse(Console.ReadLine(), out a) ? a : 0;

    switch (a)
    {
        case 1:
            vManager.AddCars();
            break;
        case 12:
            vManager.AddMoto();
            break;
        case 2:
            vManager.RemoveVehicle();
            break;
        case 3:
            vManager.ListAll();
            break;
        case 4:
            vManager.ListAllSummary();
            break;
        case 5:
            vManager.EditVehicle();
            break;
        default:
            break;
    }
}
while (a != 9);
