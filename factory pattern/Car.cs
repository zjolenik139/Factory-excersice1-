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
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The car is driving wildly! YEHAA!");
        }
    }


    
}
