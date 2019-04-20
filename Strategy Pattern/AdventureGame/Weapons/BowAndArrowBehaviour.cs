using System;
using AdventureGame.BaseClass;

namespace AdventureGame.Weapon
{
    public class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public void useWeapon()
        {
            System.Console.WriteLine("Shooting an arrow with a bow.");
        }
    }
}