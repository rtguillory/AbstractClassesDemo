using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI 
{
    internal class Motorcycle : Vehicle
    {
        public Boolean HasSideCar { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle is being ridden. ");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This motorcycle is moving. ");
        }

    }

    
}
