using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    [Header("ステータス一覧")]
    [Range(0, 5000)]
    [SerializeField]
    private int _life = 0;
    [SerializeField]
    private List<CardData> _deck = default;
    [SerializeField]
    private List<CardData> _handingCards = default;

    public List<CardData> Deck => _deck;
    public List<CardData> HandingCards => _handingCards;

    private void Start()
    {

    }

    private void Update()
    {

    }

    #region Playerの行動一覧
    public abstract void CardDraw();
    #endregion
}
