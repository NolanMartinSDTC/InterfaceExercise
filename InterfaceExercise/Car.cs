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
	public class Car : IVehicle, ICompany
	{
		public Car()
		{
		}

        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public bool RunsOnGas { get ; set ; }
        public bool HasWindows { get ; set ; }

        public string Logo { get ; set ; }
        public string Name { get ; set ; }

        public bool TrunkStorage { get; set; }
        public bool HighMPG { get; set; }

        public static void CarProperties(Car car)
		{
			Console.WriteLine($"Fun Facts about The {car.Name}");
			Console.WriteLine($"**insert {car.Logo} here**");
			Console.WriteLine("-------------------------------------");
			Console.WriteLine($"Has {car.NumberOfWheels} wheels!\nHas {car.NumberOfDoors} doors!\n" +
				$"{((car.RunsOnGas) ? "Runs on gas!" : "Is electric!")}\n" +
				$"{((car.HasWindows) ? "Has windows!" : "Has no windows!")}\n" +
				$"{((car.TrunkStorage) ? "Has trunk storage space!" : "Has no trunk storage space!")}\n" +
				$"{((car.HighMPG) ? "Has great gas mileage!" : "Has terrible gas mileage!")}\n");
		}
    }
}

