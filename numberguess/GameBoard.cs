using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumberGuess
{
    public partial class GameBoard : Form
    {
        int guess;
        string result;
        NumberGame game = new NumberGame();
        int correctNum;
        bool gameOver;
        int numOfGuesses;
        int numOfWins;
        int numOfLosses;
        string recentGuesses;

        public GameBoard()
        {
            InitializeComponent();
            lblInstructions.Text = "Play this game by trying to guess the random number generated\n"+
            " between 1-100 by the computer within 10 guesses.";
            numOfGuesses = game.Guesses();
            lblGuesses.Text = "Guesses: " + numOfGuesses;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            correctNum = game.RandomNum();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            guess = int.Parse(tbGuess.Text);
            result = game.Guess(guess, correctNum);
            lblInstructions.Text = result;
            numOfGuesses = game.Guesses();
            recentGuesses = game.RecentGuesses(guess);
            lblrecentGuesses.Text = recentGuesses;
            lblGuesses.Text = "Guesses: " + numOfGuesses;
            gameOver = game.GameStatus();
            if (gameOver)
            {
                numOfWins = game.CheckWin();
                lblWins.Text = "Wins: " + numOfWins;
                numOfLosses = game.CheckLoss();
                lblLosses.Text = "Losses: " + numOfLosses;
                btnEnter.Enabled = false;
            }
            tbGuess.Text = "";

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            game.NewGame();
            correctNum = game.RandomNum();
            lblInstructions.Text = "Play this game by trying to guess the random number generated\n" +
            " between 1-100 by the computer within 10 guesses.";
            tbGuess.Text = "";
            lblLosses.Text = "Losses: " + numOfLosses;
            lblWins.Text = "Wins: " + numOfWins;
            lblGuesses.Text = "Guesses: 0";
            btnEnter.Enabled = true;
            lblrecentGuesses.Text = "";
        }
    }
}
