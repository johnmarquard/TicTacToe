using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public IKi KI { get; private set; }
        bool PVE = MassageBoxWhichGamePlay.PlayerVsEnemy;

        public Form1(IKi ki)
        {
            InitializeComponent();
            button1.Tag = 1;
            button2.Tag = 2;
            button3.Tag = 3;
            button4.Tag = 4;
            button5.Tag = 5;
            button6.Tag = 6;
            button7.Tag = 7;
            button8.Tag = 8;
            button9.Tag = 9;
            KI = ki;
        }

        string WhichPlayer = "X";
        int PlayerOnePoints = 0;
        int PlayerTwoPoints = 0;
        bool IsWon = false;
        string[] buttonStates = new string[9];
       

        private void ButtonUpdate(string Field)
        {
            foreach (var comp in Controls)
            {
                if (comp is Button)
                {
                    var button = ((Button)comp);

                        if (button.Tag?.ToString() == Field)
                        {
                            buttonStates[Convert.ToInt32(Field) - 1] = WhichPlayer;
                            button.Text = WhichPlayer;
                            button.Enabled = false;
                        }
                    
                }
            }

            HasWon();

            if (!IsWon)
            {
                if (IsFieldFree())
                {
                    NextTurn();
                }
                else
                {
                    Draw();

                }
            }
        }

        private void Draw()
        {
            TextBox.Text = "Draw";
        }

        private bool IsFieldFree()
        {
            return buttonStates.Any(s => s == null);
        }

        private void NextTurn()
        {
            if (WhichPlayer == "X")
            {
                WhichPlayer = "O";
                TextBox.Text = "PlayerTwo(O)";

                if (PVE)
                {
                    var fieldToSet = KI.GetNextStep(buttonStates);
                    ButtonUpdate(fieldToSet);
                    
                }
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
                ButtonUpdate(((Button)sender).Tag.ToString());
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
                textBoxY.Text = $"PlayerTwo(O) Points = {PlayerTwoPoints}";
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

        private void ButtonRevenge(object sender, EventArgs e)
        {
            buttonStates = new string[buttonStates.Length];
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
