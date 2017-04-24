﻿using System;
namespace PatternDecorator.Ingredients
{
    public class Chocolat : DecoratorIngredient
    {
        public Chocolat(Boisson boisson) : base(boisson)
        {
        }

		public override double Cout()
		{
			return this.boisson.Cout() + 1;
		}

		public override string GetDescription()
		{
			return this.boisson.GetDescription() + ", Chocolat";
		}
    }
}
