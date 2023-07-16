using StateMachine;
using UnityEngine;

public class MainTwoPhase : IState
{
    public void OnEnter(StateMachineRoot owner)
    {
        Debug.Log("Enter MainTwo Phase");
    }

    public void OnUpdate(StateMachineRoot owner)
    {

    }

    public void OnExit(StateMachineRoot owner)
    {
        Debug.Log("Exit MainTwo Phase");
    }
}
