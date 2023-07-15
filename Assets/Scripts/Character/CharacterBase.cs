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

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}
