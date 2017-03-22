using System;
namespace BoissonTemplate
{
	public class Chocolat : BoissonAvecAdaptation
	{
		public override void AjouterSupplementSelonBoisson()
		{
			Console.WriteLine("Ajout Cannel");
		}

		public override void UtiliserEau()
		{
			Console.WriteLine("Mélanger Eau avec Chocolat");
		}
	}
}
