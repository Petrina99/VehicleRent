using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public interface IVehicle
    {
        void GetAllInfo();
        int GetHP();
        int GetMileage();
        string GetBasicInfo();
        void EditVehicle();
    }
}
