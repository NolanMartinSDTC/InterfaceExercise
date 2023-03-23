//In ICompany

 /*Create 2 members that are specific to each every company
  * regardless of vehicle type.
  *
  *
  * Example: public string Logo { get; set; }
  */
using System;
namespace InterfaceExercise
{
	public interface ICompany
	{
		public string Logo { get; set; }
		public string Name { get; set; }
	}
}

