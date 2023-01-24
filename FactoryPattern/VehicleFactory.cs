using System;
namespace FactoryPattern
{
	public class VehicleFactory
	{
		public VehicleFactory()
		{
		}

		public static IVehicle GetVehicle(string wheelCount)
		{
            switch (wheelCount)
			{
				case "2":
					return new Motorcycle();
				case "4":
					return new Car();
				default:
					return new Car();
			}

		}

	}
}

