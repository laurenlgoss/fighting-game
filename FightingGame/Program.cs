using FightingGame.App;

try
{
    FightingGameApp app = new();

    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}