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

        public Motorcylce(string make, string model, int year, int hp, string typeOfMotorcycle, string strokeType)
        {
            VehicleType = "Car";
            Make = make;
            Model = model;
            Year = year;
            Horsepower = hp;
            TypeOfMotorcycle = typeOfMotorcycle;
            StrokeType = strokeType;
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
    }
}
