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

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void EditVehicle(string vin)
        {
            Vehicle vehicleToEdit = vehicles.Find(x => x.VIN == vin);
            if (vehicleToEdit != null) 
            { 
                vehicleToEdit.EditVehicle()
            }
        }
        public void RemoveVehicle(string vin)
        {
            Vehicle vehicleToRemove = vehicles.Find(x => x.VIN == vin);

            if (vehicleToRemove != null)
            {
                vehicles.Remove(vehicleToRemove);
            }
        }

        public void ListAll()
        {
            foreach (Vehicle v in vehicles)
            {
                v.GetAllInfo();
            }
        }

        public void ListAllSummary()
        {
            foreach (Vehicle v in vehicles)
            {
                v.GetBasicInfo();
            }
        }
    }
}
