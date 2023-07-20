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

    public void PlayBGM(BGM_TYPE bgm, bool isLoop)
    {
        _bgmSource.Stop();

        _bgmSource.loop = isLoop;
        _bgmSource.clip = _soundHolder.BgmClips[(int)bgm];
        _bgmSource.Play();
    }

    public void PlaySE(SE_TYPE se)
    {
        _seSource.Stop();

        _seSource.clip = _soundHolder.SeClips[(int)se];
        _seSource.Play();
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
