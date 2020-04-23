using UnityEngine;

namespace Decorator
{
    class BonusDamageModifier : BulletModifier
    {
        [SerializeField]
        private float _bonusDamage;

        public BonusDamageModifier(IDamager modifiedDamage, float bonusDamage):base (modifiedDamage)
        {
            _bonusDamage = bonusDamage;
        }

        protected override void Modify()
        {
            _modifiedDamage.AddDamage(_bonusDamage);
        }
    }
}
