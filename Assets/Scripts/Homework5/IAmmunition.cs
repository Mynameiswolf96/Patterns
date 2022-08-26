using UnityEngine;

namespace Zoork.Homework5
{
    public interface IAmmunitiom
    {
        Transform BarrelPositionAim { get; }
        GameObject AimInstance { get; }
    }
}