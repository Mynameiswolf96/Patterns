using UnityEngine;

namespace Strategy.Scripts
{
    public class StrategyExample : MonoBehaviour
    {
        private IBehaviour _behaviour;


        [ContextMenu("Test Regular")]
        private void TestRegular()
        {
            _behaviour = new RegularBehaviour();
            _behaviour.DoSomething();
        }


        [ContextMenu("Test Strange")]
        private void TestStrange()
        {
            _behaviour = new StrangeBehaviour();
            _behaviour.DoSomething();
        }
    }
}