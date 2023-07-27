using UnityEngine;
using UnityEngine.UI;

public class OptionUI : SceneUIBase
{
    [SerializeField]
    private Slider _bgmSlider = default;
    [SerializeField]
    private Slider _seSlider = default;

    private void Start()
    {
        Init();
    }

    public override void Init()
    {
        _bgmSlider.value = 1;
        _seSlider.value = 1;

        _bgmSlider.onValueChanged.AddListener(
            (value) => { SoundManager.Instance.VolumeSettingBGM(_bgmSlider.value); });
        _seSlider.onValueChanged.AddListener(
            (value) => { SoundManager.Instance.VolumeSettingSE(_seSlider.value); });
    }
}
