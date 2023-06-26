using FightingGame.Characters;
using FightingGame.Game;
using FightingGame.UserInteraction;

namespace FightingGame.App;

/// <summary>
/// Manages fighting game app workflow.
/// </summary>
public class FightingGameApp
{
    private readonly IFightingGameUserInteractor _fightingGameUserInteractor;
    private readonly IFightingGame _fightingGame;

    public FightingGameApp(IFightingGameUserInteractor fightingGameUserInteractor, IFightingGame fightingGame)
    {
        _fightingGameUserInteractor = fightingGameUserInteractor;
        _fightingGame = fightingGame;
    }

    /// <summary>
    /// Starts the fighting game application.
    /// </summary>
    public void Run()
    {
        // Prompt user to build character
        Player player = _fightingGameUserInteractor.BuildPlayer();

        // Generate enemy
        Enemy enemy = new();

        // Start fighting game
        GameResult result = _fightingGame.Play(player, enemy);

        // Show result
        _fightingGameUserInteractor.ShowResult(result);
    }
}