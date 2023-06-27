using FightingGame.App;
using FightingGame.UserInteraction;

ConsoleUserInteractor userInteractor = new();
FightingGameUserInteractor fightingGameUserInteractor = new(userInteractor);
FightingGame.Game.FightingGame fightingGame = new();
FightingGameApp app = new(fightingGameUserInteractor, fightingGame);

try
{
    app.Run();
}
catch (Exception ex)
{
    userInteractor.PrintError(ex);
}

userInteractor.Exit();