using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var car = new Car() { IsElectric = false, Make = "Honda", Model = "Accord", Year = "2023"};
            var car2 = new Car();
            var motorcycle = new Motorcycle() { HasSideCar = false, Year = "2020", Model = "Roadster", Make = "Harley-Davidson"} ;
            Vehicle vehicle1 = new Car() { Make = "Hyundai", Model = "Ioniq 5", Year = "2023", IsElectric = true  };
            Vehicle vehicle2 = new Motorcycle() { Year = "2021", Model = "Diavel 1260", Make = "Ducati", HasSideCar = true };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(car2);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"\nYear: {vehicle.Year}\nMake: {vehicle.Make}" +
                    $"\nModel: {vehicle.Model}");
                if(vehicle.GetType() == typeof(Car)) 
                { 
                    Console.WriteLine($"Electric: {((Car)vehicle).IsElectric}");
                }
                else if(vehicle.GetType() == typeof(Motorcycle))
                {
                    Console.WriteLine($"Side Car: {((Motorcycle)vehicle).HasSideCar}");
                }
            }

            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine();
            car.DriveAbstract();
            motorcycle.DriveAbstract();
            motorcycle.DriveVirtual();
            #endregion            
            Console.ReadLine();
        }
    }
}
