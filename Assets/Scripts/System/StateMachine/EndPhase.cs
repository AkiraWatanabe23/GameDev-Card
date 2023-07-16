using Constants;
using StateMachine;
using UnityEngine;

public class EndPhase : IState
{
    public void OnEnter(StateMachineRoot owner)
    {
        Debug.Log("Enter End Phase");
    }

    public void OnUpdate(StateMachineRoot owner)
    {
        GameManager.Instance.ChangeTurn(
            GameManager.Instance.CurrentTurn != Turn.PLAYER ? Turn.PLAYER : Turn.OPPONENT);

        owner.ChangeState(StateMachineRoot.States.PHASE_START);
    }

    public void OnExit(StateMachineRoot owner)
    {
        Debug.Log("Exit End Phase");
    }
}
