using System;
namespace BoissonTemplate
{
	public class Cafe: BoissonAvecAdaptation
	{
		public Cafe()
		{
		}

		public override void AjouterSupplementSelonBoisson()
		{
			Console.WriteLine("Ajout de lait et de sucre");
		}

		public override void UtiliserEau()
		{
			Console.WriteLine("Filtrer l'eau avec le café");
		}

		public override bool ClientVeutSupplement()
		{
			Console.WriteLine("Voulez-vous un supplément ? y-n");
			var result = Console.ReadLine();
			return result == "y" ? true : false;
		}
	}
}
