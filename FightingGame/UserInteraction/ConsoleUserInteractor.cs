namespace FightingGame.UserInteraction;

/// <summary>
/// Interacts with user via Console.
/// </summary>
public class ConsoleUserInteractor : IUserInteractor
{
    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }

    public void PrintError(Exception ex)
    {
        ConsoleColor defaultTextColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ForegroundColor = defaultTextColor;
    }

    public void PrintMessage(string message) => Console.WriteLine(message);
}