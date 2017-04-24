using System;
namespace PatternDecorator.Ingredients
{
    public class Lait : DecoratorIngredient
    {
        public Lait(Boisson boisson) : base(boisson)
        {
        }

		public override double Cout()
		{
			return this.boisson.Cout() + 1.5;
		}

		public override string GetDescription()
		{
			return this.boisson.GetDescription() + ", Lait";
		}
    }
}
