using System;
using UnityEngine;

namespace Assets.Scripts
{
    class Enemy : MonoBehaviour
    {
        public IStats _stats;
        public void SetStats(IStats stats)
        {
            _stats = stats;
        }
        public IScale _scale;
        public void SetScale(IScale scale)
        {
            _scale = scale;
        }
        public IDamage _damage;
        public void SetDamage(IDamage damage)
        {
            _damage = damage;
        }

    }
}
