using System;
//using System.Numerics;
using ClassLibrary1;
namespace Practice_ClassLibraries
{
    class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Red");
            Air air = new Air("Green");
            Helicopter helicopter = new Helicopter("Blue", 2);
            Plane plane = new Plane("Pink", 3);
            Sea sea = new Sea("Orange", "Submarine");
            Land land = new Land("Purple", 4);

            vehicles.Add(vehicle);
            vehicles.Add(air);
            vehicles.Add(helicopter);
            vehicles.Add(plane);
            vehicles.Add(sea);
            vehicles.Add(land);

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v);
            }

        }
    }
}