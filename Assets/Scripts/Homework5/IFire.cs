using UnityEngine;

namespace Homework5
{
    public interface IFire
    {
        void Fire();
    }

    public interface IAmmunition
    {
        
        Rigidbody BulletInstance { get; }
        float TimeToDestroy { get; }

    }
}