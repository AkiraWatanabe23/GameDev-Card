using System;
using UnityEngine;

namespace StateMachine
{
    [Serializable]
    public class StateMachineRoot
    {
        private IState _currentState = default;

        public IState CurrentState => _currentState;

        public void Init()
        {
            _currentState.OnEnter(this);
        }

        public void Update()
        {
            _currentState.OnUpdate(this);
        }

        private IState GetState(States state)
        {
            switch (state)
            {
                case States.None: return null;
            }
            Debug.LogError("No State");
            return null;
        }

        public void ChangeState(States nextState)
        {
            _currentState.OnExit(this);
            _currentState = GetState(nextState);
            _currentState.OnEnter(this);
        }

        public enum States
        {
            None,
        }
    }
}
