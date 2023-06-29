// 日本語対応
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    [SerializeReference]
    [SubclassSelector] private ITest _test = default;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}
