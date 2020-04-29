
namespace Visitor.ExampleHit
{
    public sealed class RegenEnemy : Hit
    {
        public float RegenHp;
        public bool RegenChance;
        
        public override void Activate(IDealingDamage value, float damage)
        {
            value.Visit(this, new InfoCollision(damage));
        }
    }
}
