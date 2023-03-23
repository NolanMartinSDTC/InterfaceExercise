//In your IVehicle

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: All vehicles have a number of wheels... for now..
 */
using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int NumberOfWheels { get; set; }
		public int NumberOfDoors { get; set; }
		public bool RunsOnGas { get; set; }
		public bool HasWindows { get; set; }
	}
}

