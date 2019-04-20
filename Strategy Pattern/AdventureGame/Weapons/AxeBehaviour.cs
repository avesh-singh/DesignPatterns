using System;
using AdventureGame.BaseClass;

namespace AdventureGame.Weapon
{
    public class AxeBehaviour:IWeaponBehaviour
    {
        public void useWeapon(){
            System.Console.WriteLine("Chopping with the axe.");
        }
    }
}