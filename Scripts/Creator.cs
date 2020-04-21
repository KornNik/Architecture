using UnityEngine;

namespace Builder
{
    public abstract class Creator : MonoBehaviour
    {
        [SerializeField] protected Mesh _mesh;
        [SerializeField] protected Material _material;
        [SerializeField] protected int _countObj;
        [SerializeField] protected int _radius = 100;
        protected Vector3 _vector3;
        public ObjectType Type = ObjectType.Capsule;


        private void Start()
        {
            for (int i = 0; i < _countObj; i++)
            {
                float angle = i * Mathf.PI * 2 / _countObj;
                _vector3 = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * _radius;
                CreateObj();
            }
        }

        public abstract void CreateObj();

    }
}
