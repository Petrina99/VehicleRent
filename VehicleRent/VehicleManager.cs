using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class VehicleManager
    {
        public List<Vehicle> vehicles;

        public VehicleManager() 
        { 
            vehicles = new List<Vehicle>();
        }

        public void AddCars()
        {
            Car newCar = Car.AddCar();
            vehicles.Add(newCar);
        }

        public void AddMoto()
        {
            Motorcylce newMoto = Motorcylce.AddMoto();
            vehicles.Add(newMoto);
        }

        public void EditVehicle()
        {
            Console.WriteLine("Enter VIN of vehicle to edit: ");
            string vin = Console.ReadLine();
            Vehicle vehicleToEdit = vehicles.Find(x => x.VIN == vin);
            if (vehicleToEdit != null) 
            {
                vehicleToEdit.EditVehicle();
            }
        }
        public void RemoveVehicle()
        {
            Console.WriteLine("Enter VIN of vehicle to be deleted: ");
            string vin = Console.ReadLine();
            Vehicle vehicleToRemove = vehicles.Find(x => x.VIN == vin);

            if (vehicleToRemove != null)
            {
                vehicles.Remove(vehicleToRemove);
            }
        }

        public void ListAll()
        {
            if (vehicles != null) 
            {
                foreach (Vehicle v in vehicles)
                {
                    v.GetAllInfo();
                }
            }
            else
            {
                Console.WriteLine("No vehicles in a list");
            }

        }

        public void ListAllSummary()
        {
            if (vehicles != null)
            {
                foreach (Vehicle v in vehicles)
                {
                    v.GetBasicInfo();
                }
            } else
            {
                Console.WriteLine("No vehicles in a list");
            }
            
        }
    }
}
