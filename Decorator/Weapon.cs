using UnityEngine;


namespace Decorator
{
    public sealed class Weapon : MonoBehaviour
    {
        [SerializeField] private float _shotVolume;
        [SerializeField] private Transform _placeForMuffler;
        [SerializeField] private Transform _placeForAim;
        [SerializeField]private Bullet bullet;

        public void SetShotVolume(float shotVolume)
        {
            _shotVolume -= shotVolume;
        }

        public Vector3 MufflerPosition()
        {
            return _placeForMuffler.position;
        }

        public Vector3 AimPosition()
        {
            return _placeForAim.position;
        }
        private void Start()
        {
            bullet = Resources.Load<Bullet>("Bullet");
        }
        private void Update()
        {
            Shooting();
        }
        private void Shooting()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                var ammunition = Instantiate(bullet, _placeForMuffler.position, _placeForMuffler.rotation);
                ammunition.AddForce(_placeForMuffler.right*1000);
            }

        }
    }
}
