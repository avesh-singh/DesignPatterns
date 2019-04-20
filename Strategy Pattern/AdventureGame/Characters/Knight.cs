using System;
using AdventureGame.BaseClass;

namespace AdventureGame.Characters
{
    public class Knight : Character
    {
        IWeaponBehaviour weapon;
        public override void fight() => weapon.useWeapon();
    }
}