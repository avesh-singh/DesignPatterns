using System;

namespace StarBuzzCoffee.Beverages
{
    public class Espresso:Beverage
    {
        public Espresso(){
            description = "This is Espresso Coffee";
        }
        public override float cost()
        {
            return 1.99f;
        }
    }
}