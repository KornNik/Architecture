using UnityEngine;

public sealed class Bullet : Ammunition
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var tempObj = collision.gameObject.GetComponent<ISetDamage>();

        if (tempObj != null)
        {
            tempObj.SetDamage(new InfoCollision(_baseDamage, collision.transform));
        }
        DestroyAmmunition();
    }
}