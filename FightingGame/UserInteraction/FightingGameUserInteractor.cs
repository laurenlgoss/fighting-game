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

    public Player BuildPlayer()
    {
        _userInteractor.PrintMessage("Create your character:");

        string name = ReadStatString(nameof(Player.Name));
        byte health = ReadStat(nameof(Player.Attack));
        byte attack = ReadStat(nameof(Player.Health));
        byte defense = ReadStat(nameof(Player.Defense));

        return new Player(name, health, attack, defense);
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

    private byte ReadStat(string statName)
    {
        string statString = ReadStatString(statName);

        byte stat;
        while (!byte.TryParse(statString, out stat))
        {
            _userInteractor.PrintMessage("Enter valid number.");
            statString = ReadStatString(statName);
        }
        return stat;
    }

    public void ShowResult(GameResult result) => _userInteractor.PrintMessage(result.Message());
}