using System;
using AdventureGame.BaseClass;

namespace AdventureGame.Characters
{
    public class King:Character
    {
        IWeaponBehaviour weapon;
        public override void fight() => weapon.useWeapon();        
    }
}