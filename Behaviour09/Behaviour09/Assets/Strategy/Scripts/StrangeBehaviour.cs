using UnityEngine;

namespace Strategy.Scripts
{
    public class StrangeBehaviour : IBehaviour
    {
        public void DoSomething()
        {
            Debug.Log("StrangeBehaviour.DoSomething: ");
        }
    }
}