//In each of your car, truck, and suv classes

 /*Create 2 members that are specific to each class
  * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
  *
  * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
  * 
  */
using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
		}

        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public bool RunsOnGas { get ; set ; }
        public bool HasWindows { get; set; }

        public string Logo { get ; set ; }
        public string Name { get ; set ; }

        public bool LargeStorage { get; set; }
        public bool DecentMPG { get; set; }

        public static void TruckProperties(Truck truck)
        {
            Console.WriteLine($"Fun Facts about The {truck.Name}");
            Console.WriteLine($"**insert {truck.Logo} here**");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Has {truck.NumberOfWheels} wheels!\nHas {truck.NumberOfDoors} doors!\n" +
                $"{((truck.RunsOnGas) ? "Runs on gas!" : "Is electric!")}\n" +
                $"{((truck.HasWindows) ? "Has windows!" : "Has no windows!")}\n" +
                $"{((truck.LargeStorage) ? "Has large storage space in the bed!" : "The truck doesn't have a bed!")}\n" +
                $"{((truck.DecentMPG) ? "Has decent gas mileage!" : "Has terrible gas mileage!")}\n");
                
        }
    }
}

