using UnityEngine;

namespace Visitor.Scripts
{
    public class InfoCollision
    {
        public float Damage { get; set; }
        public Vector3 Point { get; set; }
        public Vector3 Normal { get; set; }
        public Transform ObjCollision { get; set; }


        public InfoCollision(float damage, Vector3 hitInfoPoint, Vector3 hitInfoNormal, Transform colliderTransform)
        {
            Damage = damage;
            Point = hitInfoPoint;
            Normal = hitInfoNormal;
            ObjCollision = colliderTransform;
        }
    }
}