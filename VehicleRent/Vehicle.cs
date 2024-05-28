using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public abstract class Vehicle : IVehicle
    {
        public string? VehicleType { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public int Horsepower { get; set; }
        public int Mileage { get; set; }
        public string FuelType { get; set; }
        public string VIN { get; set; }

        public virtual void GetAllInfo()
        {
            Console.WriteLine($"Type of vehicle: {this.VehicleType}, Make: {this.Make}, Model: {this.Model}, Year: {this.Year}" +
                $" Horsepower: {this.Horsepower}, Mileage: {this.Mileage} km, Fuel type: {this.FuelType}, VIN: {this.VIN}");
        }

        public virtual string GetBasicInfo()
        {
            return $"Type: {this.VehicleType}, Make: {this.Make}, Model: {this.Model}";
        }

        public int GetHP()
        {
            return this.Horsepower;
        }

        public int GetMileage()
        {
            return this.Mileage;
        }

        public virtual void EditVehicle()
        {
            Console.WriteLine("Editing vehicle");
            Console.Write($"New type (current: {VehicleType}): ");
            VehicleType = Console.ReadLine();
            Console.Write($"New Make (current: {Make}): ");
            Make = Console.ReadLine();
            Console.Write($"New Model (current: {Model}): ");
            Model = Console.ReadLine();
        }
    }
}
