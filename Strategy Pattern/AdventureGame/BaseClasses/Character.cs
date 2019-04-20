using System;

namespace AdventureGame.BaseClass
{
    public abstract class Character
    {
        IWeaponBehaviour weapon;
        public abstract void fight();
        public void setWeapon(IWeaponBehaviour weapon) => this.weapon = weapon;
    }
}