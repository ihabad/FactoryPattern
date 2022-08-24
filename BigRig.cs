using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    internal class BigRig : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine($"It's a big ride, but one of the most comfortable I've ever experienced!");
        }
    }
}
