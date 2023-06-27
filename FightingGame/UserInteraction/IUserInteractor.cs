namespace FightingGame.UserInteraction;

/// <summary>
/// Interacts with user.
/// </summary>
public interface IUserInteractor
{
    void PrintMessage(string message);
    void PrintError(Exception ex);
    void Exit();
    string? ReadInput();
}
