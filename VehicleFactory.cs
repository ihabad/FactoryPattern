using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int WindowsCount)
        {
            switch(WindowsCount)
            {
                case 6:
                    return new Car();

                case 7:
                    return new BigRig();

               default:
                    return new Motorcycle();

            }

            

        }

	    
    }
}
