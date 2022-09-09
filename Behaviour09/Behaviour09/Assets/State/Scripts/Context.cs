using UnityEngine;

namespace State.Scripts
{
    public class Context
    {
        private IState _currentState;

        public void SetState(IState state)
        {
            _currentState = state;
        }


        public void SayCurrent()
        {
            var stateSaying = _currentState.Say();
            Debug.Log($"Context.Act: {stateSaying}");
        }
    }
}