using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class Car : Vehicle
    {
        public string? TypeOfCar { get; set; }
        public int CubicCapacity { get; set; }
        public double TrunkSize { get; set; }

        public Car(string make, string model, int year, string typeOfCar, int cCapacity, double trunkSize) 
        {
            VehicleType = "Car";
            Make = make;
            Model = model;
            Year = year;
            TypeOfCar = typeOfCar;
            CubicCapacity = cCapacity;
            TrunkSize = trunkSize;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Type of vehicle: {this.VehicleType}, Make: {this.Make}, Model: {this.Model}, Year: {this.Year}, " +
                $" Type of car: {this.TypeOfCar}, Cubic capacity: {CubicCapacity}, Trunk size: {this.TrunkSize}");
        }
    }
}
