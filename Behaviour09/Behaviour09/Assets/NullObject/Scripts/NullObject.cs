using UnityEngine;

namespace NullObject.Scripts
{
    public class NullObject : IObject
    {
        public void DoSomething()
        {
            Debug.Log("NullObject.DoSomething: Having a break");
        }
    }
}