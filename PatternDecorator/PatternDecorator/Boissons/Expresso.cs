using System;
namespace PatternDecorator
{
    public class Expresso : Boisson
    {
        public Expresso()
        {
        }

        public override double Cout()
        {
            return 1.0;
        }

        public override string GetDescription()
        {
            return "Expresso";
        }
    }
}
