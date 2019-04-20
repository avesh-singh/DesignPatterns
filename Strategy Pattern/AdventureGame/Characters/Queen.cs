using System;
using AdventureGame.BaseClass;

namespace AdventureGame.Characters
{
    public class Queen : Character
    {
        IWeaponBehaviour weapon;
        public override void fight() => weapon.useWeapon();
    }
}