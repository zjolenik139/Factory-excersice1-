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
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Motorcycle is cruising!");
            Console.WriteLine("VRROOOM VRROM");
        }
    }
}
