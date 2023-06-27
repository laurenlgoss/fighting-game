namespace FightingGame.Characters;

public interface ICharacter
{
    public string Name { get; }
    public int Health { get; }
    public int Attack { get; }
    public int Defense { get; }
    //public int Speed { get; }

    public void ReduceHealth(int attack);
    public bool IsAlive();
}