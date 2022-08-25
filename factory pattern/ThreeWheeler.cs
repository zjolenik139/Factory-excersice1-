using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {

        }
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("Lets ride pall.");
        }
    }
}
