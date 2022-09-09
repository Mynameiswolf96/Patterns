using UnityEngine;

namespace NullObject.Scripts
{
    public class NullObjectExample : MonoBehaviour
    {
        [ContextMenu("Test Null Object")]
        private void TestNullObject()
        {
            IObject[] objects = { new RealObject(), new RealObject(), new NullObject(), new RealObject() };

            foreach (var anObject in objects)
            {
                anObject.DoSomething();
            }
        }
    }
}