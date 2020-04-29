using System;

namespace Assets.Scripts
{
    public interface IHit
    {
        event Action<float> OnHitChange;
        void Hit(float damage);
    }
}
