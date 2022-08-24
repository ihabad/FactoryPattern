using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    internal class Motorcycle : IVehicle
    {
        public Motorcycle()
        { 
        }

        public void Drive()
        {
            Console.WriteLine($"It will be a fast motorcycle you will be riding, so be careful!");
        }
    }
}
