/// <summary> 対戦相手の管理クラス </summary>
public class OpponentController : CharacterBase
{
    private DataHolder _dataHolder = new();

    private void Start()
    {
        _dataHolder.SetOpponent(this);
    }

    public override void CardDraw()
    {
        throw new System.NotImplementedException();
    }
}
