using UnityEngine;

namespace State.Scripts
{
    public class StateExample : MonoBehaviour
    {
        [ContextMenu("Test State")]
        private void TestState()
        {
            var context = new Context();

            var concreteStateA = new ConcreteStateA();
            context.SetState(concreteStateA);
            context.SayCurrent();

            var concreteStateB = new ConcreteStateB();
            context.SetState(concreteStateB);
            context.SayCurrent();
        }


        [ContextMenu("Test Inversed State")]
        private void TestInversedState()
        {
            var context = new Context();

            var concreteStateA = new ConcreteStateA();
            concreteStateA.Do(context);
            context.SayCurrent();

            var concreteStateB = new ConcreteStateB();
            concreteStateB.Do(context);
            context.SayCurrent();
        }
    }
}