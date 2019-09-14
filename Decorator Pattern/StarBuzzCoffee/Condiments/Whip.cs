using System;
using StarBuzzCoffee.Beverages;

namespace StarBuzzCoffee.Condiments
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }

        public override float cost()
        {
            return beverage.cost() + 0.10f;
        }
    }
}