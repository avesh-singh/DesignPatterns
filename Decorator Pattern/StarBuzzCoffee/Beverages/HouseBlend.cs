using System;

namespace StarBuzzCoffee.Beverages
{
    public class HouseBlend:Beverage
    {
        public HouseBlend(){
            description = "This is House Blend Coffee";
        }
        public override float cost(){
            return 0.89f;
        }
    }
}