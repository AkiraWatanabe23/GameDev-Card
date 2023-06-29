using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardData : ScriptableObject
{
    [SerializeField, SerializeReference, SubclassSelector]
    private List<IAbility> _abilities;

    [SerializeField, SerializeReference, SubclassSelector]
    private List<ICondition> _conditions;

    public List<IAbility> Abilities => _abilities;
    public List<ICondition> Conditions => _conditions;
}
