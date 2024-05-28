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

        public Car() {
            VehicleType = "Car";
        }
        public Car(string make, string model, int year, int hp, string typeOfCar, int cCapacity, int mileage, string fuelType, string vin) 
        {
            VehicleType = "Car";
            Make = make;
            Model = model;
            Year = year;
            Horsepower = hp;
            TypeOfCar = typeOfCar;
            CubicCapacity = cCapacity;
            Mileage = mileage;
            FuelType = fuelType;
            VIN = vin;
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
                $" Type of car: {this.TypeOfCar}, Cubic capacity: {CubicCapacity},  " +
                $"Horsepower: {this.Horsepower}, Mileage: {this.Mileage} km, Fuel type: {this.FuelType}, " +
                $"VIN: {VIN}");
        }

        public override string GetBasicInfo()
        {
            return $"Make: {this.Make}, Model: {this.Model}, Year: {this.Year}";
        }

        public override void EditVehicle()
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
            Console.Write($"New mileage(current: {Mileage}): ");
            int m = Int32.TryParse(Console.ReadLine(), out m) ? m : Mileage;
            Mileage = m;
            Console.Write($"New fuel tpye (current: {FuelType}): ");
            FuelType = Console.ReadLine();
        }

        public static Car AddCar()
        {
            Car newCar = new Car();

            Console.WriteLine("Adding a car");
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
            Console.Write($"Type of car: ");
            newCar.TypeOfCar = Console.ReadLine();
            Console.Write($"Cubic capacity: ");
            int c = Int32.TryParse(Console.ReadLine(), out c) ? c : 0;
            newCar.CubicCapacity = c;
            Console.Write("VIN: ");
            newCar.VIN = Console.ReadLine();

            return newCar;
        }
    }   
    
}
