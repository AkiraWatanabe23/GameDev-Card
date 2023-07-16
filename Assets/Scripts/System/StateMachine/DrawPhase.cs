using StateMachine;
using UnityEngine;

public class DrawPhase : IState
{
    public void OnEnter(StateMachineRoot owner)
    {
        Debug.Log("Enter Draw Phase");
    }

    public void OnUpdate(StateMachineRoot owner)
    {

    }

    public void OnExit(StateMachineRoot owner)
    {
        Debug.Log("Exit Draw Phase");
    }
}
