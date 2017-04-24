using System;
namespace PatternDecorator.Boissons
{
	public class Deca : Boisson
	{
		public Deca()
		{
		}

		public override double Cout()
		{
			return 2.0;
		}

		public override string GetDescription()
		{
			return "Café décaféiné";
		}
	}
}
