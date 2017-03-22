using System;

namespace BoissonTemplate
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			BoissonAvecAdaptation cafe = new Cafe();
			cafe.SuivreLaRecette();

			BoissonAvecAdaptation the = new The();
			the.SuivreLaRecette();

			BoissonAvecAdaptation ch = new Chocolat();
			ch.SuivreLaRecette();
		}
	}
}
