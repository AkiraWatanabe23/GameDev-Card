using StateMachine;
using UnityEngine;

public class StartPhase : IState
{
    public void OnEnter(StateMachineRoot owner)
    {
        Debug.Log("Enter Start Phase");
    }

    public void OnUpdate(StateMachineRoot owner)
    {
        owner.ChangeState(States.PHASE_DRAW);
    }

    public void OnExit(StateMachineRoot owner)
    {
        Debug.Log("Exit Start Phase");
    }
}
