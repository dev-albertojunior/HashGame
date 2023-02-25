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
            this.Hide();
            Frm_Game Game = new Frm_Game();
            Game.Show();
        }
    }
}
