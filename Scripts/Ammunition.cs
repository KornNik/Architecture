using UnityEngine;



public abstract class Ammunition : MonoBehaviour
{
    [SerializeField] protected float _timeToDestruct = 10;
    [SerializeField] protected float _baseDamage = 10;

    public BulletType Type = BulletType.Bullet;

    private void Start()
    {
        DestroyAmmunition(_timeToDestruct);
    }

    protected void DestroyAmmunition(float timeToDestruct = 0)
    {
        Destroy(gameObject, timeToDestruct);
        CancelInvoke(nameof(_timeToDestruct));
    }

}