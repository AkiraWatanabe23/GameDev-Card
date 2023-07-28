using Constants;
using StateMachine;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private DataLoader _dataLoader = new();
    [SerializeField]
    private StateMachineRoot _stateMachineRoot = new();

    [Header("Debug")]
    [SerializeField]
    private bool _isDebugMode = false;

    public Turn CurrentTurn { get; private set; }
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
        if (!_isDebugMode) _stateMachineRoot.Init();
        else
        {
            UIManager.Instance.Init();
            _dataLoader.Init();
        }
    }

    public void ChangeTurn(Turn nextTurn)
    {
        CurrentTurn = nextTurn;
    }
}
