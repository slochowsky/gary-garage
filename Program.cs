using System;

namespace GaryGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna plane = new Cessna () {
                MainColor = "Blue",
                MaximumOccupancy = "6",
                FuelCapacity = 22.2
            };

            Ram truck = new Ram () {
                MainColor = "Red",
                MaximumOccupancy = "20",
                FuelCapacity = 40.5
            };

            truck.Drive ();
        }
    }
}
