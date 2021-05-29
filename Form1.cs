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
            {
                game_board.Enabled = false;

                foreach (Control slots in game_board.Controls)
                {
                    if (slots is Button)
                    {
                        slots.Click += new System.EventHandler(choose_slot);
                    }
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
                press.Enabled = false;
                winner();
            }
            else
            {
                press.Text = "O";
                message.Text = "Your Turn, Player X";
                press.Enabled = false;
                winner();

            }
            playing++;
        }
        bool win = false;
        int player_score;
        public void winner()
        {
            if (slot1.Text == "X" && slot2.Text == "X" && slot3.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
                player_win(slot1, slot2, slot3);
                game_board.Enabled = false;
                player_score = int.Parse(playerX_score.Text);
                playerX_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot4.Text == "X" && slot5.Text == "X" && slot6.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
                player_win(slot4, slot5, slot6);
                game_board.Enabled = false;
                player_score = int.Parse(playerX_score.Text);
                playerX_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot7.Text == "X" && slot8.Text == "X" && slot9.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
                player_win(slot7, slot8, slot9);
                game_board.Enabled = false;
                player_score = int.Parse(playerX_score.Text);
                playerX_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot1.Text == "X" && slot4.Text == "X" && slot7.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
                player_win(slot1, slot4, slot7);
                game_board.Enabled = false;
                player_score = int.Parse(playerX_score.Text);
                playerX_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot2.Text == "X" && slot5.Text == "X" && slot8.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
                player_win(slot2, slot5, slot8);
                game_board.Enabled = false;
                player_score = int.Parse(playerX_score.Text);
                playerX_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot3.Text == "X" && slot6.Text == "X" && slot9.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
                player_win(slot3, slot6, slot9);
                game_board.Enabled = false;
                player_score = int.Parse(playerX_score.Text);
                playerX_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot1.Text == "X" && slot5.Text == "X" && slot9.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
                player_win(slot1, slot5, slot9);
                game_board.Enabled = false;
                player_score = int.Parse(playerX_score.Text);
                playerX_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot3.Text == "X" && slot5.Text == "X" && slot7.Text == "X")
            {
                win = true;
                message.Text = "Congratulations Player X";
                player_win(slot3, slot5, slot7);
                game_board.Enabled = false;
                player_score = int.Parse(playerX_score.Text);
                playerX_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot1.Text == "O" && slot2.Text == "O" && slot3.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
                player_win(slot1, slot2, slot3);
                game_board.Enabled = false;
                player_score = int.Parse(playerO_score.Text);
                playerO_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot4.Text == "O" && slot5.Text == "O" && slot6.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
                player_win(slot4, slot5, slot6);
                game_board.Enabled = false;
                player_score = int.Parse(playerO_score.Text);
                playerO_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot7.Text == "O" && slot8.Text == "O" && slot9.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
                player_win(slot7, slot8, slot9);
                game_board.Enabled = false;
                player_score = int.Parse(playerO_score.Text);
                playerO_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot1.Text == "O" && slot4.Text == "O" && slot7.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
                player_win(slot1, slot4, slot7);
                game_board.Enabled = false;
                player_score = int.Parse(playerO_score.Text);
                playerO_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot2.Text == "O" && slot5.Text == "O" && slot8.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
                player_win(slot2, slot5, slot8);
                game_board.Enabled = false;
                player_score = int.Parse(playerO_score.Text);
                playerO_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot3.Text == "O" && slot6.Text == "O" && slot9.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
                player_win(slot3, slot6, slot9);
                game_board.Enabled = false;
                player_score = int.Parse(playerO_score.Text);
                playerO_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot1.Text == "O" && slot5.Text == "O" && slot9.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
                player_win(slot1, slot5, slot9);
                game_board.Enabled = false;
                player_score = int.Parse(playerO_score.Text);
                playerO_score.Text = Convert.ToString(player_score + 1);
            }
            if (slot3.Text == "O" && slot5.Text == "O" && slot7.Text == "O")
            {
                win = true;
                message.Text = "Congratulations Player O";
                player_win(slot3, slot5, slot7);
                game_board.Enabled = false;
                player_score = int.Parse(playerO_score.Text);
                playerO_score.Text = Convert.ToString(player_score + 1);
            }
            if (game_draw() == 9 && win == false)
            {
                message.Text = "It is a Draw, No Winner";
            }

        }
        public int game_draw()
        {
            int allTextButtonsLength = 0;
            foreach (Control slots in game_board.Controls)
            {
                if (slots is Button)
                {
                    allTextButtonsLength += slots.Text.Length;
                }
            }
            return allTextButtonsLength;
        }
        public void player_win(Button one, Button two, Button three)
        {
            one.BackColor = Color.Aquamarine;
            two.BackColor = Color.Aquamarine;
            three.BackColor = Color.Aquamarine;
        }
        private void start_game_Click(object sender, EventArgs e)
        {
            game_board.Enabled = true;
            message.Text = "Your Turn, Player X";
            start_game.Visible = false;
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            game_board.Enabled = true;
            playing = 0;
            win = false;
            playerX_score.Text = "0";
            playerO_score.Text = "0";
            message.Text = "Your Turn, Player X";
            foreach (Control slots in game_board.Controls)
            {
                if (slots is Button)
                {
                    slots.Enabled = true;
                    slots.Text = "";
                    slots.BackColor = Color.White;
                }
            }
        }
        private void next_match_Click(object sender, EventArgs e)
        {
            game_board.Enabled = true;
            playing = 0;
            win = false;
            message.Text = "Your Turn, Player X";
            foreach (Control slots in game_board.Controls)
            {
                if (slots is Button)
                {
                    slots.Enabled = true;
                    slots.Text = "";
                    slots.BackColor = Color.White;
                }
            }
        }
        private void close_program_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    } 
}