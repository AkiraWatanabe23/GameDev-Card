public interface ISceneUI
{
    /// <summary> 各シーンで使用するUIの初期設定のみ行い、利用はManager, Playerに一任する </summary>
    public void Init();
}
