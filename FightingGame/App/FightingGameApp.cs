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
        Character character = _fightingGameUserInteractor.BuildCharacter();

        // Generate enemy
        Enemy enemy = new();

        // Start fight
        GameResult result = _fightingGame.Start(character, enemy);

        // Show result
        _fightingGameUserInteractor.ShowResult(result);
    }
}