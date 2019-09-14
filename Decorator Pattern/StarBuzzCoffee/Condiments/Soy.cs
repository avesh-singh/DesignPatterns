using System;
using StarBuzzCoffee.Beverages;

namespace StarBuzzCoffee.Condiments
{
    class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        public override float cost()
        {
            return beverage.cost() + 0.15f;
        }
    }
}