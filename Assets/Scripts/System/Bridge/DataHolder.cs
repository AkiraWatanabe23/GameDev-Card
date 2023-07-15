public class DataHolder
{
    public CharacterBase Player { get; private set; }
    public CharacterBase Opponent { get; private set; }

    public void GetPlayer(CharacterBase character)
    {
        Player = character;
    }

    public void GetOpponent(CharacterBase character)
    {
        Opponent = character;
    }

    public void GetData()
    {

    }

    public void SetData()
    {

    }
}
