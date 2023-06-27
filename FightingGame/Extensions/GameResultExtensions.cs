using FightingGame.Game;

namespace FightingGame.Extensions
{
    public static class GameResultExtensions
    {
        public static string Message(this GameResult result)
        {
            switch (result)
            {
                case GameResult.Victory:
                    return "Congratulations, you won!";
                case GameResult.Loss:
                    return "You lost.";
            }

            return "";
        }
    }
}

