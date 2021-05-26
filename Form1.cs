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
            if (press.Text.Equals(""))
            {

            }
            if (playing % 2 == 0)
            {
                press.Text = "X";
                message.Text = "Your Turn, Player O";
                press.ForeColor = Color.Red;
                winner();
            }
            else
            {
                press.Text = "O";
                message.Text = "Your Turn, Player X";
                press.ForeColor = Color.Green;
                winner();
            }
            playing++;
        }
        bool win = false;
        public void winner()
        {
             if (slot1.Text == "X" && slot2.Text == "X" && slot3.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
            }
            if (slot4.Text == "X" && slot5.Text == "X" && slot6.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
            }
            if (slot7.Text == "X" && slot8.Text == "X" && slot9.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
            }
            if (slot1.Text == "X" && slot4.Text == "X" && slot7.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
            }
            if (slot2.Text == "X" && slot4.Text == "X" && slot8.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
            }
            if (slot3.Text == "X" && slot6.Text == "X" && slot9.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
            }
            if (slot1.Text == "X" && slot5.Text == "X" && slot9.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
            }
            if (slot3.Text == "X" && slot5.Text == "X" && slot7.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
            }
            if (slot1.Text == "O" && slot2.Text == "O" && slot3.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player X";
            }
            if (slot4.Text == "O" && slot5.Text == "O" && slot6.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
            }
            if (slot7.Text == "O" && slot8.Text == "O" && slot9.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
            }
            if (slot1.Text == "O" && slot4.Text == "O" && slot7.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
            }
            if (slot2.Text == "O" && slot4.Text == "O" && slot8.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
            }
            if (slot3.Text == "O" && slot6.Text == "O" && slot9.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
            }
            if (slot1.Text == "O" && slot5.Text == "O" && slot9.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
            }
            if (slot3.Text == "O" && slot5.Text == "O" && slot7.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
            }
        }
    }
}