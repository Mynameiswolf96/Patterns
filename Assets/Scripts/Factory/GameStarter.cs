using UnityEngine;
namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            Enemy.CreateAsteroidEnemy(new HP(100.0f, 100.0f));
            
        }
    }
}