using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Slider _bgmSlider = default;
    [SerializeField] private Slider _seSlider = default;

    private string _currentScene = default;

    private void Start()
    {
        _bgmSlider.onValueChanged.AddListener(
            (value) => { SoundManager.Instance.VolumeSettingBGM(_bgmSlider.value); });
        _seSlider.onValueChanged.AddListener(
            (value) => { SoundManager.Instance.VolumeSettingSE(_seSlider.value); });
    }

    private void Update()
    {

    }
}
