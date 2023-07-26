using UnityEngine;

public abstract class SceneUIBase : MonoBehaviour
{
    protected virtual void Update() { }

    /// <summary> 各シーンに存在するUIの初期化処理 </summary>
    public abstract void Init();
}
