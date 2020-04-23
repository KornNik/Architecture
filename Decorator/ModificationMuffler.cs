using UnityEngine;


namespace Decorator
{
    public sealed class ModificationMuffler : ModificationWeapon
    {
        public override Object AddModification(Weapon weapon)
        {
            var muffler = Object.Instantiate(Resources.Load<GameObject>(AssetPath.Modifications[ModificationWeaponType.Muffler]),
            weapon.MufflerPosition(), Quaternion.identity, weapon.transform);
            weapon.SetShotVolume(5);
            return muffler;
        }
        public override void RemoveModification(Object obj)
        {
            Object.Destroy(obj);
        }
    }
}
