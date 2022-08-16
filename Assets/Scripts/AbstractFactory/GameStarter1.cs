using UnityEngine;
namespace Asteroids.Abstrac_Factory
{
    internal sealed class GameStarter1 : MonoBehaviour
    {
        private void Start()
        {
            var platform = new PlatformFactory().Create(Application.platform);
        }
    }
}