using System;
using System.Threading;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        static FieldToText FTT = new FieldToText();
        public Form1()
        {
            InitializeComponent();
        }

        string WhichPlayer = "X";
        int PlayerOnePoints = 0;
        int PlayerTwoPoints = 0;
        bool IsWon = false;

        private void ButtonUpdate(string Field)
        {
            string Textxy = $"button{Field}.Text = WhichPlayer";
            Textxy;


            HasWon();

            if (IsWon)
            { }
            else
            {
                DontWon();
            }
        }

        private void DontWon()
        {
            if (WhichPlayer == "X")
            {
                WhichPlayer = "Y";
                TextBox.Text = "PlayerTwo(Y)";
            }

            else
            {
                WhichPlayer = "X";
                TextBox.Text = "PlayerOne(X)";
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                ButtonUpdate(((Button)sender).Text);
            }

        }

        private void HasWon()
        {
            if (button1.Text + button2.Text + button3.Text == WhichPlayer + WhichPlayer + WhichPlayer)
            {
                TextBox.Text = $"{WhichPlayer} Won";
                PlayerPoints();
            }

            if (button4.Text + button5.Text + button6.Text == WhichPlayer + WhichPlayer + WhichPlayer)
            {
                TextBox.Text = $"{WhichPlayer} Won";
                PlayerPoints();
            }

            if (button7.Text + button8.Text + button9.Text == WhichPlayer + WhichPlayer + WhichPlayer)
            {
                TextBox.Text = $"{WhichPlayer} Won";
                PlayerPoints();
            }

            if (button7.Text + button5.Text + button3.Text == WhichPlayer + WhichPlayer + WhichPlayer)
            {
                TextBox.Text = $"{WhichPlayer} Won";
                PlayerPoints();
            }

            if (button9.Text + button5.Text + button1.Text == WhichPlayer + WhichPlayer + WhichPlayer)
            {
                TextBox.Text = $"{WhichPlayer} Won";
                PlayerPoints();
            }

            if (button7.Text + button4.Text + button1.Text == WhichPlayer + WhichPlayer + WhichPlayer)
            {
                TextBox.Text = $"{WhichPlayer} Won";
                PlayerPoints();
            }

            if (button2.Text + button5.Text + button8.Text == WhichPlayer + WhichPlayer + WhichPlayer)
            {
                TextBox.Text = $"{WhichPlayer} Won";
                PlayerPoints();
            }

            if (button9.Text + button6.Text + button3.Text == WhichPlayer + WhichPlayer + WhichPlayer)
            {
                TextBox.Text = $"{WhichPlayer} Won";
                PlayerPoints();
            }
        }

        private void PlayerPoints()
        {
            IsWon = true;
            if (WhichPlayer == "X")
            {
                PlayerOnePoints = PlayerOnePoints + 1;
                textBoxX.Text = $"PlayerOne(X) Points = {PlayerOnePoints}";
            }

            else
            {
                PlayerTwoPoints = PlayerTwoPoints + 1;
                textBoxY.Text = $"PlayerTwo(Y) Points = {PlayerTwoPoints}";
            }
            GameOver();
        }

        private void GameOver()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }

        private void Buttonevange(object sender, EventArgs e)
        {
            IsWon = false;
            WhichPlayer = "X";
            TextBox.Text = "PlayerOne(X)";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
        }
    }
}
