using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC339_Connect4
{
    public partial class Form1 : Form
    {
        private Board board;
        public Form1()
        {
            InitializeComponent();
            
            this.Paint += new PaintEventHandler(Pic_board_Paint);
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            board = new Board();


        }

        private void Pic_board_Paint(object sender, PaintEventArgs e)
            {
            board.DrawBoard(e.Graphics);
            }

        // Return board to previous state and begin game again
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            board.ResetBoard();
            confettiPictureBox.Visible = false;
            columnFullLabel.Text = "";
            currentPlayerLabel.Text = "It is " + board.GetPlayerName() + "'s turn";
            currentPlayerLabel.Visible = true;
            this.Refresh();
        }

        // Toggles rules label
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rulesLabel.Visible == true)
            {
                rulesLabel.Visible = false;
                rulesTitleLabel.Visible = false;
            } 
            else
            {
                rulesLabel.Visible = true;
                rulesTitleLabel.Visible = true;
            }
        }

        // Begin game after getting player names
        private void StartButton_Click(object sender, EventArgs e)
        {
            board.SetPlayerNames(nameBox1.Text, nameBox2.Text);
            board.gameStarted = true;

            // Hides startup boxes from the user's view
            welcomeMessageBox.Hide();
            nameBox1.Hide();
            nameBox2.Hide();
            playerTextLabel.Hide();
            startButton.Hide();
            currentPlayerLabel.Visible = true;
            currentPlayerLabel.Text = "It is " + board.GetPlayerName() + "'s turn";
        }

        // Verifies the player's move after clicking any column button. Controls the game's states.
        private void VerifyMove(int column)
        {
            if (board.gameStarted & board.win == false)
            {
                columnFullLabel.Visible = true;
                if (board.AddPiece(column) == true)
                {
                    columnFullLabel.Text = "";
                    if (board.CheckWin())
                    {
                        this.Refresh();
                        columnFullLabel.Text = board.winningPlayer + " wins!";
                        confettiPictureBox.Visible = true;
                        currentPlayerLabel.Visible = false;
                    }
                    else if (board.CheckTie())
                    {
                        columnFullLabel.Text = "Tie game!";
                        currentPlayerLabel.Visible = false;
                    }
                    else
                    {
                        board.NextTurn();
                        currentPlayerLabel.Text = "It is " + board.GetPlayerName() + "'s turn";
                        this.Refresh();
                    }
                }
                else
                {
                    columnFullLabel.Text = "Column is full, try a different one!";
                }
            }
        }

        private void Column1_Click(object sender, EventArgs e)
        {
            VerifyMove(0);
        }

        private void Column2_Click(object sender, EventArgs e)
        {
            VerifyMove(1);
        }

        private void Column3_Click(object sender, EventArgs e)
        {
            VerifyMove(2);
        }

        private void Column4_Click(object sender, EventArgs e)
        {
            VerifyMove(3);
        }

        private void Column5_Click(object sender, EventArgs e)
        {
            VerifyMove(4);
        }

        private void Column6_Click(object sender, EventArgs e)
        {
            VerifyMove(5);
        }

        private void Column7_Click(object sender, EventArgs e)
        {
            VerifyMove(6);
        }

        private void NameBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void WelcomeMessageBox_Click(object sender, EventArgs e)
        {

        }

        private void ColumnFullLabel_Click(object sender, EventArgs e)
        {
            
        }

    }
}
