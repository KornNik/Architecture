using System.Collections.Generic;

namespace Builder
{
    public static class Weight
    {
        public static readonly Dictionary<ObjectType, int> Weights = new Dictionary<ObjectType, int>
        {
            {ObjectType.Capsule, 10},
            {ObjectType.Cube,5 }
        };
    }
}