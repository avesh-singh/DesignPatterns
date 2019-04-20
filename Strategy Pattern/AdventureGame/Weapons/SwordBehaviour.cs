using System;
using AdventureGame.BaseClass;

namespace AdventureGame.Weapon
{
    public class SwordBehaviour : IWeaponBehaviour
    {
        public void useWeapon()
        {
            System.Console.WriteLine("Swinging a sword.");
        }
    }
}