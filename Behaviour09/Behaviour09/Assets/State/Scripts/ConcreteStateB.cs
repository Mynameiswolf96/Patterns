using UnityEngine;

namespace State.Scripts
{
    public class ConcreteStateB : IState
    {
        public void Do(Context context)
        {
            Debug.Log("ConcreteStateB.DoAction: ");

            context.SetState(this);
        }


        public string Say()
        {
            Debug.Log("ConcreteStateB.Say: ");

            return "B";
        }
    }
}