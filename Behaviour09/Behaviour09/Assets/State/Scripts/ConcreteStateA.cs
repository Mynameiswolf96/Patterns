using UnityEngine;

namespace State.Scripts
{
    public class ConcreteStateA : IState
    {
        public void Do(Context context)
        {
            Debug.Log("ConcreteStateA.DoAction: ");

            context.SetState(this);
        }


        public string Say()
        {
            Debug.Log("ConcreteStateA.Say: ");

            return "A";
        }
    }
}