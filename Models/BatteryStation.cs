using System;
using System.Collections.Generic;

namespace gary_garage
{
	public class BatteryStation : IFuelStation<IElectricPowered>
	{
		public int Capacity { get; set; }

		public void Refuel(List<IElectricPowered> vehicles)
		{
			foreach (IElectricPowered vehicle in vehicles)
			{
				vehicle.ChargeBattery();
			}
		}
	}
}