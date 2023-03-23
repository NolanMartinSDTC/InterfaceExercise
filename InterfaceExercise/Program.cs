using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            /*
             * 
             * */

            Car saturn = new Car()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                RunsOnGas = true,
                HasWindows = true,
                Logo = "Saturn Logo",
                Name = "Ion",
                TrunkStorage = true,
                HighMPG = true,

            };

            Car.CarProperties(saturn);

            Truck toyota = new Truck()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 2,
                RunsOnGas = true,
                HasWindows = true,
                Logo = "Toyota Logo",
                Name = "Tacoma",
                LargeStorage = true,
                DecentMPG = false,
            };

            Truck.TruckProperties(toyota);

            SUV ford = new SUV()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                RunsOnGas = true,
                HasWindows = true,
                Logo = "Ford Logo",
                Name = "Expedition",
                MediumStorage = true,
                LowMPG = true,
            };

            SUV.SUVProperties(ford);
        }
    }
}
