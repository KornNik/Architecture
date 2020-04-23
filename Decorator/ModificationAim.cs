using UnityEngine;

namespace Decorator
{
    class ModificationAim : ModificationWeapon
    {
        public override Object AddModification(Weapon weapon)
        {
            var aim = Object.Instantiate(Resources.Load<GameObject>(AssetPath.Modifications[ModificationWeaponType.Aim]),
                weapon.AimPosition(), Quaternion.identity, weapon.transform);
            return aim;
        }

        public override void RemoveModification(Object obj)
        {
            Object.Destroy(obj);
        }
    }
}
