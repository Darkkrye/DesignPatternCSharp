using System;
using System.Collections.Generic;
namespace PatternDecorator
{
    public abstract class Boisson
    {
        string Description;

        public virtual double Cout() {
            return 0.0;
        }

        public virtual string GetDescription() {
            return "";
        }

        public void RecupereIngredient(List<DecoratorIngredient> li) {
            
        }
    }
}
