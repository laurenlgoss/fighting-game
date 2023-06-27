namespace FightingGame.Characters;

public interface ICharacter
{
    public string Name { get; }
    public byte Health { get; }
    public byte Attack { get; }
    public byte Defense { get; }
    //public byte Speed { get; }

    public void ReduceHealth(byte attack);
    public bool IsAlive();
}