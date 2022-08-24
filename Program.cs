using System;

namespace factory_pattern
{
    internal class Program
    {
    

        public static int WindowsCount { get; private set; }


        static void Main(string[] args)
        {
            Console.WriteLine("Your driving today will be determined by how many windows ");
            Console.WriteLine("Enter the number of windows:");

         

            var vechicle = VehicleFactory.GetVehicle(WindowsCount);
            vechicle.Drive();

        }

       
        
        
    }
}
