using UnityEngine;

namespace NullObject.Scripts
{
    public class RealObject : IObject
    {
        public void DoSomething()
        {
            Debug.Log("RealObject.DoSomething: Working hard");
        }
    }
}