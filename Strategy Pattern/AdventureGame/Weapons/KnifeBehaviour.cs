using System;
using AdventureGame.BaseClass;

namespace AdventureGame.Weapon
{
    public class KnifeBehaviour : IWeaponBehaviour
    {
        public void useWeapon()
        {
            System.Console.WriteLine("Cutting with a knife.");
        }
    }
}