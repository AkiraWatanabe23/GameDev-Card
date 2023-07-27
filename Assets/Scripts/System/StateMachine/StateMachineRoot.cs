using System;
using UnityEngine;

namespace StateMachine
{
    [Serializable]
    public class StateMachineRoot
    {
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
                case States.PhaseStart:    return _startPhase;
                case States.PhaseDraw:     return _drawPhase;
                case States.PhaseMainOne:  return _mainOnePhase;
                case States.PhaseBattle:   return _battlePhase;
                case States.PhasseMainTwo: return _mainTwoPhase;
                case States.PhaseEnd:      return _endPhase;
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
    }

    public enum States
    {
        None,
        PhaseStart,
        PhaseDraw,
        PhaseMainOne,
        PhaseBattle,
        PhasseMainTwo,
        PhaseEnd,
    }
}
