using System.Reflection;

namespace FightingGame.UserInteraction;

/// <summary>
/// Interacts with user via Console.
/// </summary>
public class ConsoleUserInteractor : IUserInteractor
{
    public void Exit()
    {
        PrintMessage("Press any key to close.");
        Console.ReadKey();
    }

    public void PrintError(Exception ex)
    {
        ConsoleColor defaultTextColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        PrintMessage(ex.Message);
        Console.ForegroundColor = defaultTextColor;
    }

    public void PrintMessage(string message) => Console.WriteLine(message);

    public string? ReadInput() => Console.ReadLine();
}