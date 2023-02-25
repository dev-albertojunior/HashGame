
namespace HashGame.Entities
{
    internal class Game
    {
        public char X { get; set; }
        public char O { get; set; }
        public char Win { get; set; }
        public string Status { get; set; }
        public char[,] Moves { get; set; } = new char[3, 3];
        public char Turn { get; set; }
        public char InitialTurn { get; set; }
        public Score X_Score { get; set; } = new Score(0,0,0);
        public Score O_Score { get; set; } = new Score(0,0,0);

        public Game(char x, char o, char initialTurn)
        {
            X = x;
            O = o;
            InitialTurn = initialTurn;
            Turn = initialTurn;
        }

        public void RestartGame()
        {
            if (InitialTurn == 'o')
            {
                InitialTurn = 'x';
            }
            else
            {
                InitialTurn = 'o';
            }

            for (int row = 0; row < 2; row++)
            {
                for (int column = 0; column < 2; column++)
                {
                    Moves[row,column] = '\0';
                }
            }
        }

        public bool CheckWin(char symbol)
        {
            // Verifies if there are 3 equal symbols in a row
            for (int row = 0; row < 3; row++)
            {
                if (Moves[row, 0] == symbol && Moves[row, 1] == symbol && Moves[row, 2] == symbol)
                {
                    return true;
                }
            }

            // Verifies if there are 3 equal symbols in a column
            for (int col = 0; col < 3; col++)
            {
                if (Moves[0, col] == symbol && Moves[1, col] == symbol && Moves[2, col] == symbol)
                {
                    return true;
                }
            }

            // Verifies if there are 3 equal symbols in the main diagonal
            if (Moves[0, 0] == symbol && Moves[1, 1] == symbol && Moves[2, 2] == symbol)
            {
                return true;
            }

            // Verifies if there are 3 equal symbols in the secondary diagonal
            if (Moves[0, 2] == symbol && Moves[1, 1] == symbol && Moves[2, 0] == symbol)
            {
                return true;
            }

            // If there are no 3 equal symbols in any row, column or diagonal, it returns false
            return false;
        }

        public bool CheckTie()
        {
            // Check if every position in the Moves matrix is filled
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (Moves[row, col] == '\0')
                    {
                        return false; // If any position is empty, it's not a tie game
                    }
                }
            }

            // If all positions are filled, check if there's a winner
            if (CheckWin('x') || CheckWin('o'))
            {
                return false; // If there's a winner, it's not a tie game
            }

            // If all positions are filled and there's no winner, it's a tie game
            return true;
        }
        
        public void RefreshScore()
        {
            if (CheckTie()==true)
            {
                X_Score.AddTies();
                O_Score.AddTies();
            }
            else if (CheckWin('x')==true)
            {
                X_Score.AddWins();
                O_Score.AddLosses();
            }
            else if(CheckWin('o')==true)
            {
                X_Score.AddLosses();
                O_Score.AddWins();
            }
        }
    }
}
