using UnityEngine;

namespace Decorator
{
    public abstract class ModificationWeapon
    {
        public abstract Object AddModification(Weapon weapon);
        public abstract void RemoveModification(Object obj);
    }
}
