using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private OptionUI _optionUI = default;

    private string _currentScene = default;
    private ISceneUI _sceneUI = default;

    private void Awake()
    {
        _currentScene = SceneManager.GetActiveScene().name;

        if (_currentScene == Consts.Scenes[SceneNames.TitleScene])
        {
            _sceneUI = FindObjectOfType<TitleUI>();
            SoundManager.Instance.PlayBGM(BGMType.TitleBGM, true);
        }
        else if (_currentScene == Consts.Scenes[SceneNames.HomeScene])
        {
            SoundManager.Instance.PlayBGM(BGMType.HomeBGM, true);
        }
        else if (_currentScene == Consts.Scenes[SceneNames.InGameScene])
        {
            SoundManager.Instance.PlayBGM(BGMType.InGameBGM, true);
        }
        else if (_currentScene == Consts.Scenes[SceneNames.ResultScene])
        {
            SoundManager.Instance.PlayBGM(BGMType.ResultBGM, true);
        }
        _sceneUI.Init();
    }
}
