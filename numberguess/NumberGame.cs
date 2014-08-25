using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuess
{
    public class NumberGame
    {
        private static int correctNum;
        private bool gameOver = false;
        private bool gameWon = false;
        private static int numOfGuesses;
        private static int numOfWins;
        private static int numOfLosses;
        private static string message;
        private static string recentGuesses;


        public int RandomNum()
        {
            Random random = new Random();
            correctNum = random.Next(1, 101);
            return correctNum;
        }
        public string Guess(int guessedNum, int correctNum)
        {
                if (guessedNum > correctNum)
                {
                    numOfGuesses += 1;
                    message = "Your Guess of " +guessedNum+" was too high";
                    if (numOfGuesses >= 10)
                    {
                        message += ", but you are out of guesses.\n"+"Click \"New Game\" to try again.";
                        gameOver = true;
                        return message;
                    }
                    else
                    {
                        message += ", try again";
                        return message;
                    }
                }
                else if (guessedNum < correctNum)
                {
                    numOfGuesses += 1;
                    message = "Your Guess of " + guessedNum + " was too low";
                    if (numOfGuesses >= 10)
                    {
                        message += ", but you are out of guesses.\n" + "Click \"New Game\" to try again.";
                        gameOver = true;
                        return message;
                    }
                    else
                    {
                        message += ", try again";
                        return message;

                    }
                }
                else 
                {
                    numOfGuesses += 1;
                    message = "You win the answer was " + correctNum;
                    gameOver = true;
                    gameWon = true;
                    return message;
                }
        }
        public string RecentGuesses(int guessedNum)
        {
            recentGuesses += "" + guessedNum + ", ";
            return recentGuesses;
        }
        public int CheckWin()
        {
            if (gameOver)
            {
                if (gameWon)
                {
                    numOfWins += 1;
                }
                else
                {
                    numOfWins += 0;
                }
            }
            return numOfWins;
        }
        public int CheckLoss()
        {
            if (gameOver)
            {
                if (!gameWon)
                {
                    numOfLosses += 1;
                }
                else
                {
                    numOfLosses += 0;
                }
            }
            return numOfLosses;
        }
        public bool GameStatus()
        {
            if (gameOver)
            {
                return true;
            }
            else { return false; }
        }
        public int Guesses()
        {
            return numOfGuesses;
        }
        public void NewGame()
        {
            numOfGuesses = 0;
            gameOver = false;
            gameWon = false;
            recentGuesses = "";
        }
     }
}

