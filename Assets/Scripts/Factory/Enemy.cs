using UnityEngine;
namespace Asteroids
{
    internal abstract class Enemy : MonoBehaviour
    {
        public HP Health{ get; private set; }
        public static Asteroid CreateAsteroidEnemy(HP hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemy.Health = hp;
            return enemy;
        }
    }
}