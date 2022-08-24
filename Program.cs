using System;
using System.ComponentModel.DataAnnotations;

namespace factory_pattern
{
    internal class Program
    {
        public static int WindowsCount { get; private set; }


        static void Main(string[] args)
        {
            Console.WriteLine("Your driving today will be determined by how many windows do you pick ");
            Console.WriteLine("Enter the number of windows:");

            var Vechicle = VehicleFactory.GetVehicle(WindowsCount);
            Vechicle.Drive();

        }

       



    }
}
