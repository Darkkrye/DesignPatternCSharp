using System;
namespace BoissonTemplate
{
	public abstract class BoissonAvecAdaptation
	{
		public abstract void AjouterSupplementSelonBoisson();

		public virtual bool ClientVeutSupplement()
		{
			return true;
		}

		public void FaireBouillirEau()
		{
			Console.WriteLine("Cuisson de l'eau. Ok !");
		}

		public abstract void UtiliserEau();

		public void VerserLaBoissonDansTasse()
		{
			Console.WriteLine("Versement de la boisson dans la tasse !");
		}

		public void SuivreLaRecette()
		{
			this.FaireBouillirEau();
			this.UtiliserEau();
			if (this.ClientVeutSupplement())
			{
				this.AjouterSupplementSelonBoisson();
			}
			this.VerserLaBoissonDansTasse();
			Console.WriteLine("");
		}
	}
}
