using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager
{
    private string _currentScene = default;
    private SceneUIBase _sceneUI = default;

    private static UIManager _instance = default;

    public string CurrentScene => _currentScene;
    public static UIManager Instance
    {
        get
        {
            _instance ??= new();
            return _instance;
        }
    }

    public void Init()
    {
        _currentScene = SceneManager.GetActiveScene().name;

        if (_currentScene == Consts.Scenes[SceneNames.TitleScene])
        {
            _sceneUI = Object.FindObjectOfType<TitleUI>();
            SoundManager.Instance.PlayBGM(BGMType.TitleBGM, true);
        }
        else if (_currentScene == Consts.Scenes[SceneNames.HomeScene])
        {
            _sceneUI = Object.FindObjectOfType<HomeUI>();
            SoundManager.Instance.PlayBGM(BGMType.HomeBGM, true);
        }
        else if (_currentScene == Consts.Scenes[SceneNames.InGameScene])
        {
            _sceneUI = Object.FindObjectOfType<InGameUI>();
            SoundManager.Instance.PlayBGM(BGMType.InGameBGM, true);
        }
        else if (_currentScene == Consts.Scenes[SceneNames.ResultScene])
        {
            _sceneUI = Object.FindObjectOfType<ResultUI>();
            SoundManager.Instance.PlayBGM(BGMType.ResultBGM, true);
        }
        else
        {
            //Debug用
            Debug.Log("MasterSceneではないため、UIの初期化を実行しません");
            return;
        }
        _sceneUI.Init();
    }
}
