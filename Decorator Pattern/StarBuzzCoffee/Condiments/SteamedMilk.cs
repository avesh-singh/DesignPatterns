using System;
using StarBuzzCoffee.Beverages;

namespace StarBuzzCoffee.Condiments
{
    class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;
        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Steamed Milk";
        }

        public override float cost()
        {
            return beverage.cost() + 0.10f;
        }
    }
}