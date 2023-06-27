namespace FightingGame.Characters;

public class Player : ICharacter
{
    public string Name { get; }
    public byte Health { get; }
    public byte Attack { get; }
    public byte Defense { get; }

    private byte _currentHealth;

    public Player(string name, byte health, byte attack, byte defense)
    {
        Name = name;
        Health = health;
        Attack = attack;
        Defense = defense;

        _currentHealth = Health;
    }

    public bool IsAlive() => _currentHealth > 0;

    public void ReduceHealth(byte attack) => _currentHealth -= attack;
}