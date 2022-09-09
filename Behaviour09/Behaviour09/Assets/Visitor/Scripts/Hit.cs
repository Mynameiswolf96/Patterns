using UnityEngine;

namespace Visitor.Scripts
{
    public abstract class Hit : MonoBehaviour
    {
        public float Health;

        public abstract void Activate(IDealingDamage value, InfoCollision infoCollision);
    }
}