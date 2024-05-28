using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class VehicleManager : IVehicle
    {
        public List<Vehicle> vehicles;

        public VehicleManager() 
        { 
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicleToRemove)
        {
            if (vehicleToRemove != null)
            {
                vehicles.Remove(vehicleToRemove);
            }
        }

        public void ListAll()
        {
            foreach (Vehicle v in vehicles)
            {
                v.GetInfo();
            }
        }
    }
}
