using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int WindowsCount)
        {
            if (WindowsCount == 8)
            {
                return new Car();
            }
            else if (WindowsCount == 6)
            {
                return new BigRig();
            }
            else
            {
                return new Motorcycle();
            }


        }
    }
}
