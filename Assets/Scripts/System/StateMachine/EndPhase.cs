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
            GameManager.Instance.CurrentTurn != Turn.Player ? Turn.Player : Turn.Opponent);

        owner.ChangeState(States.PHASE_START);
    }

    public void OnExit(StateMachineRoot owner)
    {
        Debug.Log("Exit End Phase");
    }
}
