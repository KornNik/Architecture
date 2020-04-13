using UnityEngine;

public sealed class LaserAmmunition : Ammunition
{

    [SerializeField] private float _distance = 50;
    public LaserAmmunition(Transform point, Vector3 direction)
    {
        SetLineRenderer(point, direction);
    }
    public void SetLineRenderer(Transform point, Vector3 direction)
    {
        Ray2D ray = new Ray2D(point.position, direction);

        var hit = Physics2D.Raycast(ray.origin, direction, _distance);

        Debug.DrawRay(ray.origin, direction * _distance, Color.red, _distance);

        var tempObj = hit.collider.gameObject.GetComponent<ISetDamage>();

        if (tempObj != null)
        {
            tempObj.SetDamage(new InfoCollision(_baseDamage, hit.collider.transform));
        }
    }
}
