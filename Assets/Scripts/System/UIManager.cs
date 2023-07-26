using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private OptionUI _optionUI = default;

    private string _currentScene = default;
    private SceneUIBase _sceneUI = default;

    public static UIManager Instance { get; private set; }

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

        SceneUISetting();
    }

    private void SceneUISetting()
    {
        _currentScene = SceneManager.GetActiveScene().name;

        if (_currentScene == Consts.Scenes[SceneNames.TitleScene])
        {
            _sceneUI = FindObjectOfType<TitleUI>();
            SoundManager.Instance.PlayBGM(BGMType.TitleBGM, true);
        }
        else if (_currentScene == Consts.Scenes[SceneNames.HomeScene])
        {
            _sceneUI = FindObjectOfType<HomeUI>();
            SoundManager.Instance.PlayBGM(BGMType.HomeBGM, true);
        }
        else if (_currentScene == Consts.Scenes[SceneNames.InGameScene])
        {
            _sceneUI = FindObjectOfType<InGameUI>();
            SoundManager.Instance.PlayBGM(BGMType.InGameBGM, true);
        }
        else if (_currentScene == Consts.Scenes[SceneNames.ResultScene])
        {
            _sceneUI = FindObjectOfType<ResultUI>();
            SoundManager.Instance.PlayBGM(BGMType.ResultBGM, true);
        }
        _sceneUI.Init();
    }
}
