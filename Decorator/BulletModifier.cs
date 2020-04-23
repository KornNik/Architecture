
namespace Decorator
{
    public abstract class BulletModifier : IDamager
    {
        protected IDamager _modifiedDamage;
        protected IDamageable _bulletVictim;

        public BulletModifier(IDamager modifiedDamage)
        {
            _modifiedDamage = modifiedDamage;
        }

        public void InflictDamage (IDamageable victim)
        {
            if(!_modifiedDamage.Equals(null))
            {
                _bulletVictim = victim;
                Modify();
            }
        }

        protected abstract void Modify();
        public void AddDamage(float bonusDamage)
        {

        }
    }
}
