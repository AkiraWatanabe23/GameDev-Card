using UnityEngine;

public class PlayerController : CharacterBase
{
    private DataHolder _dataHolder = new();

    private void Start()
    {
        _dataHolder.SetPlayer(this);
    }

    public override void CardDraw()
    {
        if (Deck.Count == 0) return;

        //カードを引き、手札に追加
        var card = Deck[Random.Range(0, Deck.Count)];
        Deck.Remove(card);

        HandingCards.Add(card);
    }
}
