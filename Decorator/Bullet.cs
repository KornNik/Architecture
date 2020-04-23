using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class Bullet : MonoBehaviour, IDamager
    {
        [SerializeField] private float _damage;
        [SerializeField] private float _bonusDamage;
        [SerializeField] private float _poisonDamage;
        [SerializeField] private float _poisonDuration;

        private List<BulletModifier> _modifiers = new List<BulletModifier>();
        private Rigidbody _rigidbody;

        public void InflictDamage(IDamageable victim)
        {
            for (int i = 0; i < _modifiers.Count;i++)
            {
                _modifiers[i].InflictDamage(victim);
            }
            victim.ReceiveDamage(_damage);
        }

        private void Start()
        {
            
            RegisterBulletModifier(new BonusDamageModifier(this, _bonusDamage));
            RegisterBulletModifier(new PoisonModifier(this, _poisonDamage, _poisonDuration));
        }
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void AddDamage(float extraDamage)
        {
            _damage += extraDamage;
        }

        public void RegisterBulletModifier(BulletModifier newModifier)
        {
            _modifiers.Add(newModifier);
        }
        public void AddForce(Vector3 dir)
        {
            if (!_rigidbody) return;
            _rigidbody.AddForce(dir);
        }

    }
}
