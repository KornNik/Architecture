using UnityEngine;

public sealed class Laser : Weapon, ICancelFire
{
    LaserAmmunition original;
    protected override void Awake()
    {
        base.Awake();
    }
    public override void Fire()
    {
        if (!_isReady) return;
        original = new LaserAmmunition(_barrel.transform, _barrel.right);

    }
    public void EndFire()
    {
        Destroy(original);
    }
}