using System;
using System.Collections.Generic;

namespace gary_garage
{
	public interface IFuelStation<T>
	{
		int Capacity { get; set; }
		void Refuel(List<T> vehicles);
	}
}