using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class Motorcylce : Vehicle
    {
        public string? TypeOfMotorcycle { get; set; }
        public string StrokeType { get; set; }

        public Motorcylce() {
            VehicleType = "Motorcycle";
        }
        public Motorcylce(string make, string model, int year, int hp, string typeOfMotorcycle, string strokeType, int mileage, string fuelType, string vin)
        {
            VehicleType = "Car";
            Make = make;
            Model = model;
            Year = year;
            Horsepower = hp;
            TypeOfMotorcycle = typeOfMotorcycle;
            StrokeType = strokeType;
            Mileage = mileage;
            FuelType = fuelType;
            VIN = vin;
        }

        public Motorcylce(string make, string model, int year, int hp, string strokeType)
        {
            VehicleType = "Car";
            Make = make;
            Model = model;
            Year = year;
            Horsepower = hp;
            StrokeType = strokeType;
        }

        public override void GetAllInfo()
        {
            Console.WriteLine($"Type of vehicle: {this.VehicleType}, Make: {this.Make}, Model: {this.Model}, Year: {this.Year}, " +
                $" Type of truck: {this.TypeOfMotorcycle}, Stroke type: {this.StrokeType}" +
                $" Horsepower: {this.Horsepower}, Mileage: {this.Mileage} km, Fuel type: {this.FuelType}");
        }

        public override string GetBasicInfo()
        {
            return $"Make: {this.Make}, Model: {this.Model}, Year: {this.Year}, Motorcycle type: {this.TypeOfMotorcycle}";
        }

        public override void EditVehicle()
        {
            Console.WriteLine("Editing motorcycle");
            Console.Write($"New type (current: {VehicleType}): ");
            VehicleType = Console.ReadLine();
            Console.Write($"New Make (current: {Make}): ");
            Make = Console.ReadLine();
            Console.Write($"New Model (current: {Model}): ");
            Model = Console.ReadLine();
            Console.Write($"New type of motorcycle (current: {TypeOfMotorcycle}): ");
            TypeOfMotorcycle = Console.ReadLine();
            Console.Write($"New stroke type (current: {StrokeType}): ");
            TypeOfMotorcycle = Console.ReadLine();
            Console.Write($"New Year(current: {Year}): ");
            int y = Int32.TryParse(Console.ReadLine(), out y) ? y : Year;
            Year = y;
            Console.Write($"New horsepower(current: {Horsepower}): ");
            int z = Int32.TryParse(Console.ReadLine(), out z) ? z : Horsepower;
            Horsepower = z;
            Console.Write($"New mileage(current: {Mileage}): ");
            int m = Int32.TryParse(Console.ReadLine(), out m) ? m : Mileage;
            Mileage = m;
            Console.Write($"New fuel tpye (current: {FuelType}): ");
            FuelType = Console.ReadLine();
        }

        public static Motorcylce AddMoto()
        {
            Motorcylce newCar = new Motorcylce();

            Console.WriteLine("Adding a motorcycle");
            Console.Write("Make: ");
            newCar.Make = Console.ReadLine();
            Console.Write("Model: ");
            newCar.Model = Console.ReadLine();
            Console.Write("Year: ");
            int y = Int32.TryParse(Console.ReadLine(), out y) ? y : 0;
            newCar.Year = y;
            Console.Write("Horsepower: ");
            int h = Int32.TryParse(Console.ReadLine(), out h) ? h : 0;
            newCar.Horsepower = h;
            Console.Write("Mileage: ");
            int m = Int32.TryParse(Console.ReadLine(), out m) ? m : 0;
            newCar.Mileage = m;
            Console.Write("Fuel type: ");
            newCar.FuelType = Console.ReadLine();
            Console.Write($"Type of motorcycle: ");
            newCar.TypeOfMotorcycle = Console.ReadLine();
            Console.Write($"Stroke type: ");
            newCar.StrokeType = Console.ReadLine();
            Console.Write("VIN: ");
            newCar.VIN = Console.ReadLine();

            return newCar;
        }
    }
}
