using System;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch ((GameStatus)result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            int result;

            GameItem item1 = (GameItem)Enum.Parse(typeof(GameItem),player1);
            GameItem item2 = (GameItem)Enum.Parse(typeof(GameItem),player2);

            if (player1 == player2)
            {
                result = 0; // Draw
            }
            if ((((int)item1 == 0) && ((int)item2 == 2)) ||
                (((int)item1 == 2) && ((int)item2 == 1)) ||
                (((int)item1 == 2) && ((int)item2 == 1)))
            {
                result = 1; // Player 1 wins
            }
            else
            {
                result = 2; // Player 2 wins
            }

            return result;
        }
    }
}
