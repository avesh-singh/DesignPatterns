using System;
using StarBuzzCoffee.Beverages;

namespace StarBuzzCoffee.Condiments
{
    public class Mocha:CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage){
            this.beverage = beverage;
        }

        public override string getDescription(){
            return beverage.getDescription() + ", Mocha";
        }

        public override float cost(){
            return beverage.cost() + 0.20f;
        }
    }
}