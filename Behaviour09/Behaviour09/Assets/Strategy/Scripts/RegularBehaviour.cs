using UnityEngine;

namespace Strategy.Scripts
{
    public class RegularBehaviour : IBehaviour
    {
        public void DoSomething()
        {
            Debug.Log("RegularBehaviour.DoSomething: ");
        }
    }
}