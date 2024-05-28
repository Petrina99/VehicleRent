using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public abstract class Vehicle
    {
        public string? VehicleType { get; set; }
        public string? Make { get; set; }

        public string? Model { get; set; }
        public int Year { get; set; }
        public string VIN {  get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Type of vehicle: {this.VehicleType}, Make: {this.Make}, Model: {this.Model}, Year: {this.Year}");
        }

    }
}
