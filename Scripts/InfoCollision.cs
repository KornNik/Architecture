using UnityEngine;
public struct InfoCollision
{
    private readonly float _damage;
    private readonly Transform _objCollision;

    public InfoCollision(float damage, Transform objCollision)
    {
        _damage = damage;
        _objCollision = objCollision;
    }

    public float Damage => _damage;
    public Transform ObjCollision => _objCollision;
}
