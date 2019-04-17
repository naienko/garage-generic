using System;
using System.Collections.Generic;

namespace gary_garage
{
	public class GasStation : IFuelStation<IGasPowered>
	{
		public int Capacity { get; set; }

		public void Refuel(List<IGasPowered> vehicles)
		{
			foreach (IGasPowered vehicle in vehicles)
			{
				vehicle.RefuelTank();
			}
		}
	}
}