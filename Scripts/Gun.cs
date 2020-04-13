using UnityEngine;

public sealed class Gun : Weapon
{
    [SerializeField] private float _force = 999;

    protected override void Awake()
    {
        base.Awake();
    }
    public override void Fire()
    {
        if (!_isReady) return;
        var direction = -_barrel.right * transform.localScale.x;
        var tempAmmunition = Instantiate(_ammunition, _barrel.position, _barrel.rotation);
        tempAmmunition.GetComponent<Rigidbody2D>().AddForce(direction * _force);
        _isReady = false;
        Invoke(nameof(ReadyShoot), _rechergeTime);
    }
}