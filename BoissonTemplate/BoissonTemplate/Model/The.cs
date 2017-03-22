using System;
namespace BoissonTemplate
{
	public class The: BoissonAvecAdaptation
	{
		public The()
		{
		}

		public override void AjouterSupplementSelonBoisson()
		{
			Console.WriteLine("Ajout de sucre et de citron");
		}

		public override void UtiliserEau()
		{
			Console.WriteLine("Infusion du sachet de thé dans l'eau");
		}
	}
}
