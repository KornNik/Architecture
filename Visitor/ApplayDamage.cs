using System;

namespace Visitor.ExampleHit
{
    public sealed class ApplayDamage : IDealingDamage
    {
        public void Visit(Enemy hit, InfoCollision info)
        {
            hit.Health -= info.Damage;
            hit.TextMesh.text = hit.Health.ToString();
        }

        public void Visit(Environment hit, InfoCollision info)
        {
        }

        public void Visit(Knight hit, InfoCollision info)
        {
            var hitArmor = hit.Armor/info.Damage;
            hit.Health -= hitArmor;
            hit.TextMesh.text = hit.Health.ToString();
        }

        public void Visit(RegenEnemy hit, InfoCollision info)
        {
            hit.RegenChance = new Random().Next(100) <= 20 ? true : false;
            hit.Health -= info.Damage;
            if (hit.RegenChance) { hit.Health += hit.RegenHp; }
            hit.TextMesh.text = hit.Health.ToString();
        }
    }
}
