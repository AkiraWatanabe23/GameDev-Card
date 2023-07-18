using StateMachine;
using UnityEngine;
using UnityEngine.EventSystems;

public class DrawPhase : IState, IPointerClickHandler
{
    private bool _isDraw = false;

    public void OnEnter(StateMachineRoot owner)
    {
        Debug.Log("Enter Draw Phase");
    }

    public void OnUpdate(StateMachineRoot owner)
    {
        if (_isDraw) owner.ChangeState(States.PHASE_MAIN_ONE);
    }

    public void OnExit(StateMachineRoot owner)
    {
        Debug.Log("Exit Draw Phase");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var card = eventData.pointerCurrentRaycast.gameObject;

        if (card.TryGetComponent(out PlayerController player))
        {
            player.CardDraw();
            _isDraw = true;
        }
        else if (card.TryGetComponent(out OpponentController opponent))
        {
            opponent.CardDraw();
            _isDraw = true;
        }
    }
}
