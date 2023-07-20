public class DataHolder
{
    public CharacterBase Player { get; private set; }
    public CharacterBase Opponent { get; private set; }

    public void SetPlayer(CharacterBase character)
    {
        Player = character;
    }

    public void SetOpponent(CharacterBase character)
    {
        Opponent = character;
    }
}
