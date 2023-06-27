using FightingGame.Characters;
using FightingGame.Game;

namespace FightingGame.UserInteraction;

/// <summary>
/// Encapsulates interactions with user specific to fighting game.
/// </summary>
public interface IFightingGameUserInteractor
{
    Player BuildPlayer();
    void ShowResult(GameResult result);
}
