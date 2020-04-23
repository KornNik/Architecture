
namespace Decorator
{
    class PoisonModifier : BulletModifier
    {
        private float _poisonDamage;
        private float _poisonDuration;

        public PoisonModifier(IDamager modifiedDamage, float poisonDamage, float poisonDuration) : base(modifiedDamage)
        {
            _poisonDamage = poisonDamage;
            _poisonDuration = poisonDuration;
        }

        protected override void Modify()
        {
            _bulletVictim.ReceiveDamageOverTime(_poisonDamage, _poisonDuration);
        }

    }
}
