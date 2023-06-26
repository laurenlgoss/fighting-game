using FightingGame.Characters;

namespace FightingGame.Game;

/// <summary>
/// Encapsulates fighting game logic.
/// </summary>
public interface IFightingGame
{
    GameResult Play(Player player, Enemy enemy);
}