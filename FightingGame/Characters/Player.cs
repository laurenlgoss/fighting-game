using FightingGame.Extensions;

namespace FightingGame.Characters;

public class Player : ICharacter
{
    public string Name { get; }
    public int Health { get; }
    public int Attack { get; }
    public int Defense { get; }

    public const int MaxTotalStatPoints = 100;

    private int _currentHealth;

    public Player(string name, int health, int attack, int defense)
    {
        if ((health + attack + defense) > MaxTotalStatPoints) throw new ArgumentException($"Sum of stats cannot be greater than {MaxTotalStatPoints}.");

        Name = name;
        Health = health;
        Attack = attack;
        Defense = defense;

        _currentHealth = Health;
    }

    public bool IsAlive() => _currentHealth > 0;

    public void ReduceHealth(int attack) => _currentHealth -= attack;

    public override string ToString() => this.GetProperties();
}