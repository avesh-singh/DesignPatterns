using System;
using StarBuzzCoffee.Beverages;

namespace StarBuzzCoffee.Condiments
{
    public abstract class CondimentDecorator:Beverage
    {
        public abstract string getDescription();
    }
}