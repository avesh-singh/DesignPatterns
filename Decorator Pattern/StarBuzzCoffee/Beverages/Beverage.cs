using System;

namespace StarBuzzCoffee.Beverages
{
    public abstract class Beverage
    {
        public string description = "This is a Beverage";
        public abstract float cost();
        public string getDescription(){
            return this.description;
        }
    }
}