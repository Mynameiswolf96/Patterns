using Asteroids;
using UnityEngine;

public class PrototypeEnemy : MonoBehaviour
{
  
    private Health hp;
  
    private void DeepCopyEnemy()
    {
        var origin = AsteroidFactory.Create(hp);
        var deepCopy = origin.DeepCopy();
    }
}
