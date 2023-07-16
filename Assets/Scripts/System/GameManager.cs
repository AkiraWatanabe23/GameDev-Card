using UnityEngine;
using StateMachine;
using Constants;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private StateMachineRoot _stateMachineRoot = new();

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
        Debug.Log(SoundManager.Instance == null);
        _stateMachineRoot.Init();
    }

    public void ChangeTurn(Turn nextTurn)
    {
        CurrentTurn = nextTurn;
    }
}
