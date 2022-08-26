using UnityEngine;

namespace Homework5
{
    public interface IAim
    {
        Transform BarrelPositionAim { get; }
        GameObject AimInstance { get; }
    }
}