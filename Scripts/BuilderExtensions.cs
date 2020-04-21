using UnityEngine;


namespace Builder
{
    public static partial class  BuilderExtensions
    {
        public static GameObject SetName(this GameObject gameObject, string name)
        {
            gameObject.name = name;
            return gameObject;
        }
        
        public static GameObject AddRigidbody(this GameObject gameObject, float mass)
        {
            var component = gameObject.GetOrAddComponent<Rigidbody>();
            component.mass = mass;
            component.useGravity = false;
            return gameObject;
        }
        
        public static GameObject AddBoxCollider(this GameObject gameObject)
        {
            gameObject.GetOrAddComponent<BoxCollider>();
            return gameObject;
        }

        public static GameObject AddCapsuleCollider(this GameObject gameObject)
        {
            gameObject.GetOrAddComponent<CapsuleCollider>();
            return gameObject;
        }
        
        public static GameObject AddMesh(this GameObject gameObject, Mesh mesh)
        {
            var component = gameObject.GetOrAddComponent<MeshFilter>();
            component.mesh = mesh;
            return gameObject;
        }

        public static GameObject AddMeshRenderer(this GameObject gameObject, Material material)
        {
            var component = gameObject.GetOrAddComponent<MeshRenderer>();
            component.material = material;
            return gameObject;
        }

        public static GameObject SetPosition(this GameObject gameObject, Vector3 vector3)
        {
            gameObject.transform.position = vector3;
            return gameObject;
        }

        private static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            var result = gameObject.GetComponent<T>();
            if (!result)
            {
                result = gameObject.AddComponent<T>();
            }
            return result;
        }
    }
}
