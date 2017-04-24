using System;
namespace PatternDecorator
{
    public class Maragogype : Boisson
    {
        public Maragogype()
        {
        }

        public override double Cout()
        {
            return 3.0;
        }

        public override string GetDescription()
        {
            return "Café Maragogype";
        }
    }
}
