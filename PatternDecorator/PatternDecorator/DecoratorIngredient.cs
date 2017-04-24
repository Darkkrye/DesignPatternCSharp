using System;
using System.Collections.Generic;
namespace PatternDecorator
{
    public abstract class DecoratorIngredient : Boisson
    {
        public Boisson boisson;

        public DecoratorIngredient(Boisson boisson)
        {
            this.boisson = boisson;
        }

        public void RecupereIngredients(List<DecoratorIngredient> li) {
            li.Add(this);
            boisson.RecupereIngredient(li);
        }
    }
}
