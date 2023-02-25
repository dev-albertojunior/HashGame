using HashGame.Entities;
using HashGame.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashGame
{
    public partial class Frm_Initialize : Form
    {
        public Frm_Initialize()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_NewGame_Click(object sender, EventArgs e)
        {
            if (Txt_Player1.Text != "" && Txt_Player2.Text != "")
            {
                this.Hide();
                Frm_Game StartGame = new Frm_Game();

                StartGame.Lbl_Player1.Text = Txt_Player1.Text;
                StartGame.Lbl_Player2.Text = Txt_Player2.Text;
                StartGame.Show();
            }
            else
            {
                MessageBox.Show("Insert the player's names!!!");
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
