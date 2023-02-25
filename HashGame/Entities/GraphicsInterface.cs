using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashGame.Entities
{
    internal class GraphicsInterface
    {
        public GraphicsInterface()
        {

        }

        public void ExcutePlay(Button button, Game game)
        {
            if (game.Turn == game.O)
            {
                button.Text = "O";
                game.Turn = game.X;
            }
            else
            {
                button.Text = "X";
                game.Turn = game.O;
            }

            button.Enabled = false;
        }

        public void PrintScore(Game game, Label player1, Label player2, Label tie)
        {
            player1.Text = (game.O_Score.Wins).ToString();
            player2.Text = (game.X_Score.Wins).ToString();
            tie.Text = (game.O_Score.Ties).ToString();
        }

        public void ClearTable(Button Btn_11, Button Btn_12, Button Btn_13,
                               Button Btn_21, Button Btn_22, Button Btn_23,
                               Button Btn_31, Button Btn_32, Button Btn_33)
        {
            Btn_11.Enabled = true;
            Btn_12.Enabled = true;
            Btn_13.Enabled = true;
            Btn_21.Enabled = true;
            Btn_22.Enabled = true;
            Btn_23.Enabled = true;
            Btn_31.Enabled = true;
            Btn_32.Enabled = true;
            Btn_33.Enabled = true;

            Btn_11.Text = "";
            Btn_12.Text = "";
            Btn_13.Text = "";
            Btn_21.Text = "";
            Btn_22.Text = "";
            Btn_23.Text = "";
            Btn_31.Text = "";
            Btn_32.Text = "";
            Btn_33.Text = "";
        }

        public void ShowResult(Game game, Label player1, Label player2)
        {
            if (game.CheckWin(game.O)==true)
            {
                MessageBox.Show(player1.Text + " wins!!!");
                game.RefreshScore();
                game.RestartGame();

            }
            else if (game.CheckWin(game.X) == true)
            {
                MessageBox.Show(player2.Text + " wins!!!");
                game.RefreshScore();
                game.RestartGame();
            }
            else
            {
                MessageBox.Show("It's a Tie!!!");
                game.RefreshScore();
                game.RestartGame();
            }
        }

        public void GameStatus(Game game, Label player1, Label player2,
                               Button Btn_11, Button Btn_12, Button Btn_13,
                               Button Btn_21, Button Btn_22, Button Btn_23,
                               Button Btn_31, Button Btn_32, Button Btn_33) { 
            if (game.CheckWin(game.X)==true || game.CheckWin(game.O) || game.CheckTie() == true)
            {
                ShowResult(game, player1, player2);
                ClearTable(Btn_11, Btn_12, Btn_13, Btn_21, Btn_22, Btn_23, Btn_31, Btn_32, Btn_33);
            }
        }
    }
}
