using System;
using System.Windows.Forms;
namespace TicTacToe
{
    public partial class MassageBoxWhichGamePlay : Form
    {
        public static bool PlayerVsEnemy = false;

        public MassageBoxWhichGamePlay()
        {
            InitializeComponent();
            comboBox1.Items.Insert(0, "Random Ki");
            comboBox1.Items.Insert(1, "First Free Field Ki");
            
        }

        private void RdioBtnPVE(object sender, EventArgs e)
        {
            PVEMode();
        }

        private void PVEMode()
        {
            PlayerVsEnemy = true;
            button1.Enabled = true;
        }

        private void RdioBtnPVP(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void BtnClose(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRun(object sender, EventArgs e)
        {
            IKi ki = new FirstFreeFieldKi();

            if (PlayerVsEnemy)
            { 
                if (comboBox1.SelectedIndex == 0)
                {
                    ki = new RandomKi();
                }

            }
            Form1 form2 = new Form1(ki)
            {
                Visible = true
            };
            Hide();
        }


    }
}
