using FightingGame.Characters;

namespace FightingGame.Game;

/// <summary>
/// Encapsulates fighting game logic.
/// </summary>
public interface IFightingGame
{
    GameResult Play(ICharacter player, ICharacter enemy);
}
