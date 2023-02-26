using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {
            Year = "0000";
            Make = "NoMake";
            Model = "NoModel";
        }
        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This vehicle is moving. ");
        }
    }
}
