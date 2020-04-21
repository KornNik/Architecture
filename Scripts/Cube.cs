using UnityEngine;


namespace Builder
{
    public sealed class Cube : Creator
    {
        public override void CreateObj()
        {
            new GameObject().SetName(NameManager.Cube).AddRigidbody(Weight.Weights[Type]).AddBoxCollider().AddMesh(_mesh).AddMeshRenderer(_material).SetPosition(_vector3);
        }

    }
}