using UnityEngine;
namespace Homework5.Facade
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private int _mapSize;
        [SerializeField] private string _userName;
        private void Start()
        {
            var gameService = new GameService();
            gameService.Start(_mapSize, _userName);
        }
    }
}