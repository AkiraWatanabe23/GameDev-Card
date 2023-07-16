using System;
using UnityEngine;

namespace StateMachine
{
    [Serializable]
    public class StateMachineRoot
    {
        [SerializeField]
        [SerializeReference]
        [SubclassSelector]
        private IState _currentState = default;

        #region 各ステート
        private StartPhase _startPhase = new();
        private DrawPhase _drawPhase = new();
        private MainOnePhase _mainOnePhase = new();
        private BattlePhase _battlePhase = new();
        private MainTwoPhase _mainTwoPhase = new();
        private EndPhase _endPhase = new();
        #endregion

        public IState CurrentState => _currentState;

        public void Init()
        {
            //ここで各ステートの初期化処理を行う
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
                case States.PHASE_START:    return _startPhase;
                case States.PHASE_DRAW:     return _drawPhase;
                case States.PHASE_MAIN_ONE: return _mainOnePhase;
                case States.PHASE_BATTLE:   return _battlePhase;
                case States.PHASE_MAIN_TWO: return _mainTwoPhase;
                case States.PHASE_END:      return _endPhase;
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
            NONE,
            PHASE_START,
            PHASE_DRAW,
            PHASE_MAIN_ONE,
            PHASE_BATTLE,
            PHASE_MAIN_TWO,
            PHASE_END,
        }
    }
}
