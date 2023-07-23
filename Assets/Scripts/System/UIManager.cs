using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private OptionUI _option = default;

    private string _currentScene = default;
    private ISceneUI _sceneUI = default;

    private void Awake()
    {
        _currentScene = SceneManager.GetActiveScene().name;

        if (_currentScene == Consts.Scenes[SceneNames.TitleScene])
        {
            _sceneUI = Resources.Load<TitleUI>("TitleUI");
        }
        else if (_currentScene == Consts.Scenes[SceneNames.HomeScene])
        {

        }
        else if (_currentScene == Consts.Scenes[SceneNames.InGameScene])
        {

        }
        else if (_currentScene == Consts.Scenes[SceneNames.ResultScene])
        {

        }
        _sceneUI.Init();
    }

    [System.Serializable]
    public class OptionUI : ISceneUI
    {
        [SerializeField] private Slider _bgmSlider = default;
        [SerializeField] private Slider _seSlider = default;

        public void Init()
        {
            _bgmSlider.onValueChanged.AddListener(
                (value) => { SoundManager.Instance.VolumeSettingBGM(_bgmSlider.value); });
            _seSlider.onValueChanged.AddListener(
                (value) => { SoundManager.Instance.VolumeSettingSE(_seSlider.value); });
        }
    }
}
