using FightingGame.App;
using FightingGame.UserInteraction;

ConsoleUserInteractor userInteractor = new();
FightingGameApp app = new();

try
{
    app.Run();
}
catch (Exception ex)
{
    userInteractor.PrintError(ex);
}

userInteractor.Exit();