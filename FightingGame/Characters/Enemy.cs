namespace FightingGame.Characters;

public class Enemy : ICharacter
{
    public string Name => throw new NotImplementedException();

    public byte Health => throw new NotImplementedException();

    public byte Attack => throw new NotImplementedException();

    public byte Defense => throw new NotImplementedException();

    public bool IsAlive()
    {
        throw new NotImplementedException();
    }

    public void ReduceHealth(byte attack)
    {
        throw new NotImplementedException();
    }
}