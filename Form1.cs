using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espeleta_Tic_Tac_Toe
{
    public partial class tic_tac_toe : Form
    {
        public tic_tac_toe()
        {
            InitializeComponent();
        }

        private void tic_tac_toe_Load(object sender, EventArgs e)
        {
            foreach (Control slots in game_board.Controls)
            {
                if (slots is Button)
                {
                    slots.Click += new System.EventHandler(choose_slot);
                }
            }

        }
        int playing = 0;

        public void choose_slot(object sender, EventArgs e)
        {
            Button press = (Button)sender;
            if(press.Text.Equals(""))
            {

            }
            if (playing % 2 == 0)
            {
                press.Text = "X";
                message.Text = "Your Turn, Player O";
                press.ForeColor = Color.Red;
            }
            else
            {
                press.Text = "O";
                message.Text = "Your Turn, Player X";
                press.ForeColor = Color.Green;

            }
            playing++;
            }
        }
    }