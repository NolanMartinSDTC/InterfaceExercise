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
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{
		}

        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public bool RunsOnGas { get ; set ; }
        public bool HasWindows { get ; set ; }

        public string Logo { get ; set ; }
        public string Name { get ; set ; }

        public bool MediumStorage { get; set; }
        public bool LowMPG { get; set; }

        public static void SUVProperties(SUV suv)
        {
            Console.WriteLine($"Fun Facts about The {suv.Name}");
            Console.WriteLine($"**insert {suv.Logo} here**");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Has {suv.NumberOfWheels} wheels!\nHas {suv.NumberOfDoors} doors!\n" +
                $"{((suv.RunsOnGas) ? "Runs on gas!" : "Is electric!")}\n" +
                $"{((suv.HasWindows) ? "Has windows!" : "Has no windows!")}\n" +
                $"{((suv.MediumStorage) ? "Has cargo storage!" : "Has no cargo storage!")}\n" +
                $"{((suv.LowMPG) ? "Has horrible gas mileage!" : "Has decent gas mileage!")}\n");
        }
    }
}

