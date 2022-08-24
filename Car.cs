using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    internal class Car : IVehicle
    {
        public Car()
        {

        }

        public void Drive()
        {
            Console.WriteLine($"That's a luxury car, you are lucky!");
        }
    }
}
