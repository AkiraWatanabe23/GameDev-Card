using StateMachine;
using UnityEngine;

public class BattlePhase : IState
{
    public void OnEnter(StateMachineRoot owner)
    {
        Debug.Log("Enter Battle Phase");
    }

    public void OnUpdate(StateMachineRoot owner)
    {

    }

    public void OnExit(StateMachineRoot owner)
    {
        Debug.Log("Exit Battle Phase");
    }
}
