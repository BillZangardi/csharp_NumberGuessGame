namespace NumberGuess
{
    partial class GameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblGuesses = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.lblYourGuess = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecGuess = new System.Windows.Forms.Label();
            this.lblrecentGuesses = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(189, 217);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(315, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(44, 217);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(92, 76);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(37, 13);
            this.lblWins.TabIndex = 3;
            this.lblWins.Text = "Wins: ";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(201, 76);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(46, 13);
            this.lblLosses.TabIndex = 4;
            this.lblLosses.Text = "Losses: ";
            // 
            // lblGuesses
            // 
            this.lblGuesses.AutoSize = true;
            this.lblGuesses.Location = new System.Drawing.Point(302, 76);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(54, 13);
            this.lblGuesses.TabIndex = 5;
            this.lblGuesses.Text = "Guesses: ";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(68, 20);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(61, 13);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Instructions";
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(95, 136);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(100, 20);
            this.tbGuess.TabIndex = 7;
            // 
            // lblYourGuess
            // 
            this.lblYourGuess.AutoSize = true;
            this.lblYourGuess.Location = new System.Drawing.Point(12, 139);
            this.lblYourGuess.Name = "lblYourGuess";
            this.lblYourGuess.Size = new System.Drawing.Size(62, 13);
            this.lblYourGuess.TabIndex = 8;
            this.lblYourGuess.Text = "Your Guess";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblrecentGuesses);
            this.panel1.Controls.Add(this.lblRecGuess);
            this.panel1.Location = new System.Drawing.Point(217, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 34);
            this.panel1.TabIndex = 9;
            // 
            // lblRecGuess
            // 
            this.lblRecGuess.AutoSize = true;
            this.lblRecGuess.Location = new System.Drawing.Point(67, 0);
            this.lblRecGuess.Name = "lblRecGuess";
            this.lblRecGuess.Size = new System.Drawing.Size(92, 13);
            this.lblRecGuess.TabIndex = 0;
            this.lblRecGuess.Text = "Recent Guesses: ";
            // 
            // lblrecentGuesses
            // 
            this.lblrecentGuesses.AutoSize = true;
            this.lblrecentGuesses.Location = new System.Drawing.Point(4, 13);
            this.lblrecentGuesses.Name = "lblrecentGuesses";
            this.lblrecentGuesses.Size = new System.Drawing.Size(0, 13);
            this.lblrecentGuesses.TabIndex = 1;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblYourGuess);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblGuesses);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Name = "GameBoard";
            this.Text = "Number Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblGuesses;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Label lblYourGuess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRecGuess;
        private System.Windows.Forms.Label lblrecentGuesses;
    }
}

