using System;

namespace StarBuzzCoffee.Beverages
{
    public class DarkRoast:Beverage
    {
        public DarkRoast(){
            description = "This is Dark Roast Coffee";
        }
        public override float cost()
        {
            return 0.99f;
        }
    }
}