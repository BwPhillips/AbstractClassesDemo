﻿using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool HasSideCar { get; set; } = false;

        public override void DriveAbstracts()
        {
            Console.WriteLine("This motorcycle is in drive.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} is virtually in drive.");
        }
    }
}
