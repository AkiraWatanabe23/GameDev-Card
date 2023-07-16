using StateMachine;
using UnityEngine;

public class MainOnePhase : IState
{
    public void OnEnter(StateMachineRoot owner)
    {
        Debug.Log("Enter MainOne Phase");
    }

    public void OnUpdate(StateMachineRoot owner)
    {

    }

    public void OnExit(StateMachineRoot owner)
    {
        Debug.Log("Exit MainOne Phase");
    }
}
