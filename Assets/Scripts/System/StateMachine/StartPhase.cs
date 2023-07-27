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
        owner.ChangeState(States.PhaseDraw);
    }

    public void OnExit(StateMachineRoot owner)
    {
        Debug.Log("Exit Start Phase");
    }
}
