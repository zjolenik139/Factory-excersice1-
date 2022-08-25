using System;

namespace factory_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
               Console.WriteLine("Enter thee amount of tires for the vehicle wanted:");

               input = int.TryParse(Console.ReadLine(), out wheelCount);

            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
