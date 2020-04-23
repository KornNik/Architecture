using System.Collections;
using UnityEngine;

namespace Decorator
{
    class DamagaebleObject : MonoBehaviour, IDamageable
    {
        [SerializeField] private float _hp;
        private WaitForSeconds _waitOneSecond = new WaitForSeconds(1);

        public void ReceiveDamage(float damage)
        {
            _hp -= damage;
        }

        public void ReceiveDamageOverTime(float damage, float duration)
        {
            StartCoroutine(DamageOverTime(damage, duration));
        }

        private IEnumerator DamageOverTime(float damage, float duration)
        {
            for(int i = 0; i<duration;i++)
            {
                yield return _waitOneSecond;
                _hp -= damage;
            }
        }

        void OnTriggerEnter(Collider collider)
        {
            Bullet bullet = collider.GetComponent<Bullet>();
            if(bullet)
            {
                bullet.InflictDamage(this);
            }
        }
    }
}
