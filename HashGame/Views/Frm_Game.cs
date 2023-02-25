using HashGame.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashGame.Views
{
    public partial class Frm_Game : Form
    {
        Game NewGame = new Game('x', 'o', 'o');
        GraphicsInterface Interface = new GraphicsInterface();

        public Frm_Game()
        {
            InitializeComponent();


        }

        private void Frm_Game_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_11_Click(object sender, EventArgs e)
        {
            NewGame.Moves[0, 0] = NewGame.Turn;
            Interface.ExcutePlay(Btn_11, NewGame);
            Interface.GameStatus(NewGame, Lbl_Player1, Lbl_Player2, Btn_11, Btn_12, Btn_13, Btn_21, Btn_22, Btn_23, Btn_31, Btn_32, Btn_33);
            Interface.PrintScore(NewGame, Lbl_Player1_Wins, Lbl_Player2_Wins, Lbl_Tie_Score);
        }

        private void Btn_12_Click(object sender, EventArgs e)
        {
            NewGame.Moves[0, 1] = NewGame.Turn;
            Interface.ExcutePlay(Btn_12, NewGame);
            Interface.GameStatus(NewGame, Lbl_Player1, Lbl_Player2, Btn_11, Btn_12, Btn_13, Btn_21, Btn_22, Btn_23, Btn_31, Btn_32, Btn_33);
            Interface.PrintScore(NewGame, Lbl_Player1_Wins, Lbl_Player2_Wins, Lbl_Tie_Score);
        }

        private void Btn_13_Click(object sender, EventArgs e)
        {
            NewGame.Moves[0, 2] = NewGame.Turn;
            Interface.ExcutePlay(Btn_13, NewGame);
            Interface.GameStatus(NewGame, Lbl_Player1, Lbl_Player2, Btn_11, Btn_12, Btn_13, Btn_21, Btn_22, Btn_23, Btn_31, Btn_32, Btn_33);
            Interface.PrintScore(NewGame, Lbl_Player1_Wins, Lbl_Player2_Wins, Lbl_Tie_Score);
        }

        private void Btn_21_Click(object sender, EventArgs e)
        {
            NewGame.Moves[1, 0] = NewGame.Turn;
            Interface.ExcutePlay(Btn_21, NewGame);
            Interface.GameStatus(NewGame, Lbl_Player1, Lbl_Player2, Btn_11, Btn_12, Btn_13, Btn_21, Btn_22, Btn_23, Btn_31, Btn_32, Btn_33);
            Interface.PrintScore(NewGame, Lbl_Player1_Wins, Lbl_Player2_Wins, Lbl_Tie_Score);
        }

        private void Btn_22_Click(object sender, EventArgs e)
        {
            NewGame.Moves[1, 1] = NewGame.Turn;
            Interface.ExcutePlay(Btn_22, NewGame);
            Interface.GameStatus(NewGame, Lbl_Player1, Lbl_Player2, Btn_11, Btn_12, Btn_13, Btn_21, Btn_22, Btn_23, Btn_31, Btn_32, Btn_33);
            Interface.PrintScore(NewGame, Lbl_Player1_Wins, Lbl_Player2_Wins, Lbl_Tie_Score);
        }

        private void Btn_23_Click(object sender, EventArgs e)
        {
            NewGame.Moves[1, 2] = NewGame.Turn;
            Interface.ExcutePlay(Btn_23, NewGame);
            Interface.GameStatus(NewGame, Lbl_Player1, Lbl_Player2, Btn_11, Btn_12, Btn_13, Btn_21, Btn_22, Btn_23, Btn_31, Btn_32, Btn_33);
            Interface.PrintScore(NewGame, Lbl_Player1_Wins, Lbl_Player2_Wins, Lbl_Tie_Score);
        }

        private void Btn_31_Click(object sender, EventArgs e)
        {
            NewGame.Moves[2, 0] = NewGame.Turn;
            Interface.ExcutePlay(Btn_31, NewGame);
            Interface.GameStatus(NewGame, Lbl_Player1, Lbl_Player2, Btn_11, Btn_12, Btn_13, Btn_21, Btn_22, Btn_23, Btn_31, Btn_32, Btn_33);
            Interface.PrintScore(NewGame, Lbl_Player1_Wins, Lbl_Player2_Wins, Lbl_Tie_Score);
        }

        private void Btn_32_Click(object sender, EventArgs e)
        {
            NewGame.Moves[2, 1] = NewGame.Turn;
            Interface.ExcutePlay(Btn_32, NewGame);
            Interface.GameStatus(NewGame, Lbl_Player1, Lbl_Player2, Btn_11, Btn_12, Btn_13, Btn_21, Btn_22, Btn_23, Btn_31, Btn_32, Btn_33);
            Interface.PrintScore(NewGame, Lbl_Player1_Wins, Lbl_Player2_Wins, Lbl_Tie_Score);
        }

        private void Btn_33_Click(object sender, EventArgs e)
        {
            NewGame.Moves[2, 2] = NewGame.Turn;
            Interface.ExcutePlay(Btn_33, NewGame);
            Interface.GameStatus(NewGame, Lbl_Player1, Lbl_Player2, Btn_11, Btn_12, Btn_13, Btn_21, Btn_22, Btn_23, Btn_31, Btn_32, Btn_33);
            Interface.PrintScore(NewGame, Lbl_Player1_Wins, Lbl_Player2_Wins, Lbl_Tie_Score);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame.X_Score.RestartScore();
            NewGame.O_Score.RestartScore();
            Interface.PrintScore(NewGame, Lbl_Player1_Wins, Lbl_Player2_Wins, Lbl_Tie_Score);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Initialize initialize= new Frm_Initialize();
            initialize.Show();
        }
    }
}
