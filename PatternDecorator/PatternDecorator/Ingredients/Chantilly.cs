using System;
namespace PatternDecorator.Ingredients
{
    public class Chantilly : DecoratorIngredient
    {
        public Chantilly(Boisson boisson) : base(boisson)
        {
        }

		public override double Cout()
		{
			return this.boisson.Cout() + 0.5;
		}

		public override string GetDescription()
		{
			return this.boisson.GetDescription() + ", Chantilly";
		}
    }
}
