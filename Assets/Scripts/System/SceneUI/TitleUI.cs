using Constants;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TitleUI : SceneUIBase
{
    [SerializeField]
    private Button _startButton = default;

    public override void Init()
    {
        Fade.Instance.RegisterFadeOutEvent(
            new Action[] { () => SceneLoader.LoadToScene(SceneNames.HomeScene) });

        _startButton.onClick.AddListener(() => Fade.Instance.StartFadeOut());
    }
}
