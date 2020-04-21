using UnityEngine;


namespace Builder
{
    public sealed class Capsule : Creator
    {
        public override void CreateObj()
        {
            new GameObject().SetName(NameManager.Capsule).AddRigidbody(Weight.Weights[Type]).AddCapsuleCollider().AddMesh(_mesh).AddMeshRenderer(_material).SetPosition(_vector3);
        }

    }
}