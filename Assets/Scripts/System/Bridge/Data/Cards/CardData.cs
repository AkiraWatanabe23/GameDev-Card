using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/Create Card Data")]
public class CardData : ScriptableObject
{
    [SerializeField]
    private int _cost;
    [SerializeField, SerializeReference, SubclassSelector]
    private List<IAbility> _abilities;
    [SerializeField, SerializeReference, SubclassSelector]
    private List<ICondition> _conditions;

    public int Cost => _cost;
    public List<IAbility> Abilities => _abilities;
    public List<ICondition> Conditions => _conditions;
}
