using UnityEngine;
using StateMachine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private StateMachineRoot _stateMachineRoot = new();

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        _stateMachineRoot.Init();
    }

    private void Update()
    {
        
    }
}
