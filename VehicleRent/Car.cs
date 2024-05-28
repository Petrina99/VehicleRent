using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class Car : Vehicle, IVehicle
    {
        public string? TypeOfCar { get; set; }
        public int CubicCapacity { get; set; }

        public Car(string make, string model, int year, int hp, string typeOfCar, int cCapacity) 
        {
            VehicleType = "Car";
            Make = make;
            Model = model;
            Year = year;
            Horsepower = hp;
            TypeOfCar = typeOfCar;
            CubicCapacity = cCapacity;
        }

        public Car(string make, string model, int year, int hp, int cCapacity)
        {
            VehicleType = "Car";
            Make = make;
            Model = model;
            Year = year;
            Horsepower = hp;
            CubicCapacity = cCapacity;
        }
        public override void GetAllInfo()
        {
            Console.WriteLine($"Type of vehicle: {this.VehicleType}, Make: {this.Make}, Model: {this.Model}, Year: {this.Year}, " +
                $" Type of car: {this.TypeOfCar}, Cubic capacity: {CubicCapacity}, Trunk size: {this.TrunkSize}, " +
                $"Horsepower: {this.Horsepower}, Mileage: {this.Mileage} km, Fuel type: {this.FuelType}");
        }

        public override string GetBasicInfo()
        {
            return $"Make: {this.Make}, Model: {this.Model}, Year: {this.Year}";
        }

        public void EditCar()
        {
            Console.WriteLine("Editing car");
            Console.Write($"New type (current: {VehicleType}): ");
            VehicleType = Console.ReadLine();
            Console.Write($"New Make (current: {Make}): ");
            Make = Console.ReadLine();
            Console.Write($"New Model (current: {Model}): ");
            Model = Console.ReadLine();
            Console.Write($"New type of car (current: {TypeOfCar}): ");
            TypeOfCar = Console.ReadLine();
            Console.Write($"New Year(current: {Year}): ");
            int y = Int32.TryParse(Console.ReadLine(), out y) ? y : Year;
            Year = y;
            Console.Write($"New horsepower(current: {Horsepower}): ");
            int z = Int32.TryParse(Console.ReadLine(), out z) ? z : Horsepower;
            Horsepower = z;
            Console.Write($"New cubic capacity(current: {CubicCapacity}): ");
            int c = Int32.TryParse(Console.ReadLine(), out c) ? c : CubicCapacity;
            CubicCapacity = c;
        }
    }   
    
}
