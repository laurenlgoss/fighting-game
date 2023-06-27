using FightingGame.Characters;
using FightingGame.Extensions;
using FightingGame.Game;

namespace FightingGame.UserInteraction;

/// <summary>
/// Encapsulates interactions with user specific to fighting game.
/// </summary>
public class FightingGameUserInteractor : IFightingGameUserInteractor
{
    private readonly IUserInteractor _userInteractor;

    public FightingGameUserInteractor(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    /// <summary>
    /// Prompts user to create player with custom stats.
    /// </summary>
    /// <returns>Player object created by user.</returns>
    public Player BuildPlayer()
    {
        _userInteractor.PrintMessage("Create your character:");

        string name = ReadStatString(nameof(Player.Name));

        // TODO: How to manage total stat point allotment?
        int maxTotalStatPoints = Player.MaxTotalStatPoints;
        int health = ReadStat(nameof(Player.Health));
        int attack = ReadStat(nameof(Player.Attack));
        int defense = ReadStat(nameof(Player.Defense));

        Player player = new(name, health, attack, defense);

        _userInteractor.PrintMessage(Environment.NewLine + "Player created:");
        _userInteractor.PrintMessage(player.ToString());

        return player;
    }

    private string ReadStatString(string statName)
    {
        string? stat = null;
        while (stat is null || stat == "")
        {
            _userInteractor.PrintMessage($"Enter {statName}:");
            stat = _userInteractor.ReadInput();
        }
        return stat;
    }

    private int ReadStat(string statName)
    {
        int stat;
        while (!int.TryParse(ReadStatString(statName), out stat))
        {
            _userInteractor.PrintMessage("Enter valid number.");
        }
        return stat;
    }

    public void ShowResult(GameResult result) => _userInteractor.PrintMessage(result.Message());
}