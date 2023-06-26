using FightingGame.Characters;
using FightingGame.Game;

namespace FightingGame.UserInteraction;

/// <summary>
/// Interacts with user regarding fighting game.
/// </summary>
public interface IFightingGameUserInteractor : IUserInteractor
{
    Player BuildPlayer();
    void ShowResult(GameResult result);
}