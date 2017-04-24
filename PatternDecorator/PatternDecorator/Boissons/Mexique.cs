using System;
namespace PatternDecorator
{
    public class Mexique : Boisson
    {
        public Mexique()
        {
        }

        public override double Cout()
        {
            return 1.5;
        }

        public override string GetDescription()
        {
            return "Café Mexique";
        }
    }
}
