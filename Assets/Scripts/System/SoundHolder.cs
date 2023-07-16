using UnityEngine;

public class SoundHolder : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] _bgmClips = default;
    [SerializeField]
    private AudioClip[] _seClips = default;

    public AudioClip[] BgmClips => _bgmClips;
    public AudioClip[] SeClips => _seClips;
}
