namespace TicTacToe
{
    partial class MassageBoxWhichGamePlay
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PVP = new System.Windows.Forms.RadioButton();
            this.PvE = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // PVP
            // 
            this.PVP.AutoSize = true;
            this.PVP.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PVP.Location = new System.Drawing.Point(45, 34);
            this.PVP.Name = "PVP";
            this.PVP.Size = new System.Drawing.Size(14, 13);
            this.PVP.TabIndex = 1;
            this.PVP.TabStop = true;
            this.PVP.UseVisualStyleBackColor = true;
            this.PVP.UseWaitCursor = true;
            this.PVP.CheckedChanged += new System.EventHandler(this.RdioBtnPVP);
            // 
            // PvE
            // 
            this.PvE.AutoSize = true;
            this.PvE.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PvE.Location = new System.Drawing.Point(197, 34);
            this.PvE.Name = "PvE";
            this.PvE.Size = new System.Drawing.Size(14, 13);
            this.PvE.TabIndex = 2;
            this.PvE.TabStop = true;
            this.PvE.UseVisualStyleBackColor = true;
            this.PvE.UseWaitCursor = true;
            this.PvE.CheckedChanged += new System.EventHandler(this.RdioBtnPVE);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 17);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Player Vs Player";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 90);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 17);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Player Vs";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.PvE);
            this.groupBox1.Controls.Add(this.PVP);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(50, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(50, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnRun);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnClose);
            // 
            // MassageBoxWhichGamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 203);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MassageBoxWhichGamePlay";
            this.Text = "Tic Tac Toe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton PVP;
        private System.Windows.Forms.RadioButton PvE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}