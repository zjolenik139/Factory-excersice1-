﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace factory_pattern
{
    internal class ConsoleLogger
    {
        public static void VehicleStartUpDialogue()
        {
            Console.WriteLine("Put key in ignition");
            Thread.Sleep(1000);
            Console.WriteLine("Turn key");
            Thread.Sleep(1000);
        }
    }
}
