using Constants;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static AudioSource _bgmSource = default;
    private static AudioSource _seSource = default;

    private static SoundHolder _soundHolder = default;
    private static SoundManager _instance = default;

    private static float _bgmVolume = 1f;
    private static float _seVolume = 1f;

    private int _sePlayingCount = 0;

    public static SoundManager Instance
    {
        get
        {
            if (_instance == null)
            {
                var sound = new GameObject("SoundManager");
                _instance = sound.AddComponent<SoundManager>();

                var bgm = new GameObject("BGM");
                _bgmSource = bgm.AddComponent<AudioSource>();
                bgm.transform.parent = sound.transform;

                var se = new GameObject("SE");
                _seSource = se.AddComponent<AudioSource>();
                se.transform.parent = sound.transform;

                _soundHolder = Resources.Load<SoundHolder>("SoundHolder");

                //音量設定
                _bgmSource.volume = _bgmVolume;
                _seSource.volume = _seVolume;

                DontDestroyOnLoad(sound);
            }
            return _instance;
        }
    }

    public void PlayBGM(BGMType bgm, bool isLoop)
    {
        //配列から再生するBGMを検索
        var index = 0;
        foreach (var clip in _soundHolder.BgmClips)
        {
            if (clip.BGMType == bgm) break;

            index++;
        }

        _bgmSource.Stop();

        _bgmSource.loop = isLoop;
        _bgmSource.clip = _soundHolder.BgmClips[index].BGMClip;
        _bgmSource.Play();
    }

    public void PlaySE(SEType se)
    {
        if (_sePlayingCount >= Consts.SEPlayableLimit)
        {
            Debug.Log("SE同時再生数上限に達したので、リセットします");
            _seSource.Stop();
            _sePlayingCount = 0;
        }

        var index = 0;
        foreach (var clip in _soundHolder.SeClips)
        {
            if (clip.SEType == se) break;

            index++;
        }

        _seSource.PlayOneShot(_soundHolder.SeClips[index].SEClip);
        _sePlayingCount++;
    }

    #region 以下Audio系パラメーター設定用の関数
    public void VolumeSettingBGM(float value)
    {
        _bgmSource.volume = value;
        _bgmVolume = value;
    }

    public void VolumeSettingSE(float value)
    {
        _seSource.volume = value;
        _seVolume = value;
    }
    #endregion
}
