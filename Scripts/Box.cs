using UnityEngine;
using System;

public sealed class Box : MonoBehaviour , ISetDamage
{
    public event Action Change;

    public float Health = 40;
    private bool _isDead;
    public void SetDamage(InfoCollision info)
    {
        if (_isDead) return;
        if (Health > 0)
        {
            Health -= info.Damage;
        }

        if (Health <= 0)
        {
            Destroy(gameObject, 2);

            Change?.Invoke();
            _isDead = true;
        }
    }

}