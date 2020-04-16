using System;

namespace Assets.Scripts
{
    interface IEnemyFactory
    {
        IStats CreateStats();
        IScale CreateScale();
        IDamage CreateDamage();
    }
}
