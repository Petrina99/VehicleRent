using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class Truck : Vehicle
    {
        public string? TypeOfTruck { get; set; }
        public double LoadCapacity { get; set; }

        public Truck(string make, string model, int year, int hp, string typeOfTruck, double loadCapacity)
        {
            VehicleType = "Truck";
            Make = make;
            Model = model;
            Year = year;
            Horsepower = hp;
            TypeOfTruck = typeOfTruck;
            LoadCapacity = loadCapacity;
        }

        public Truck(string make, string model, int year, int hp, double loadCapacity)
        {
            VehicleType = "Truck";
            Make = make;
            Model = model;
            Year = year;
            Horsepower = hp;
            LoadCapacity = loadCapacity;
        }

        public override void GetAllInfo()
        {
            Console.WriteLine($"Type of vehicle: {this.VehicleType}, Make: {this.Make}, Model: {this.Model}, Year: {this.Year}, " +
                $" Type of truck: {this.TypeOfTruck}, Load capacity: {LoadCapacity} " +
                $"Horsepower: {this.Horsepower}, Mileage: {this.Mileage} km, Fuel type: {this.FuelType}");
        }

        public override string GetBasicInfo()
        {
            return $"Make: {this.Make}, Model: {this.Model}, Year: {this.Year}, Load capacity: {this.LoadCapacity}, Type: {this.TypeOfTruck}";
        }
    }
}
