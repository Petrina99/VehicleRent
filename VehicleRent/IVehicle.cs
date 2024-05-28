using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public interface IVehicle
    {
        void AddVehicle(Vehicle vehicle);
        void RemoveVehicle(Vehicle vehicle);
        void ListAll();
    }
}
