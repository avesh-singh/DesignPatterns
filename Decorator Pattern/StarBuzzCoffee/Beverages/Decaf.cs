using System;

namespace StarBuzzCoffee.Beverages
{
    public class Decaf:Beverage
    {
        public Decaf(){
            description = "This is Decaf Coffee";
        }
        public override float cost()
        {
            return 1.05f;
        }
    }
}