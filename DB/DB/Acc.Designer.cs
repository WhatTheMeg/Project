namespace DB
{
    partial class Acc
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
            textBox5 = new TextBox();
            LogBox = new TextBox();
            textBox2 = new TextBox();
            PasBox = new TextBox();
            fr_button1 = new fr_Design.fr_button();
            fr_button2 = new fr_Design.fr_button();
            fr_button3 = new fr_Design.fr_button();
            fr_button4 = new fr_Design.fr_button();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(35, 35, 38);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox5.ForeColor = SystemColors.InactiveBorder;
            textBox5.Location = new Point(69, 107);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(123, 31);
            textBox5.TabIndex = 10;
            textBox5.Text = "Login";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // LogBox
            // 
            LogBox.Location = new Point(198, 111);
            LogBox.Name = "LogBox";
            LogBox.Size = new Size(544, 27);
            LogBox.TabIndex = 9;
            LogBox.TextChanged += LogBox_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(35, 35, 38);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.ForeColor = SystemColors.Menu;
            textBox2.Location = new Point(69, 159);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(123, 31);
            textBox2.TabIndex = 8;
            textBox2.Text = "Password";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // PasBox
            // 
            PasBox.Location = new Point(198, 165);
            PasBox.Name = "PasBox";
            PasBox.PasswordChar = '*';
            PasBox.Size = new Size(544, 27);
            PasBox.TabIndex = 7;
            PasBox.TextChanged += PasBox_TextChanged;
            // 
            // fr_button1
            // 
            fr_button1.BackColor = Color.DarkGray;
            fr_button1.ForeColor = Color.White;
            fr_button1.Location = new Point(379, 282);
            fr_button1.Name = "fr_button1";
            fr_button1.Size = new Size(125, 38);
            fr_button1.TabIndex = 11;
            fr_button1.Text = "Login";
            fr_button1.Click += fr_button1_Click;
            // 
            // fr_button2
            // 
            fr_button2.BackColor = Color.Transparent;
            fr_button2.ForeColor = Color.White;
            fr_button2.Location = new Point(12, 12);
            fr_button2.Name = "fr_button2";
            fr_button2.Size = new Size(99, 41);
            fr_button2.TabIndex = 12;
            fr_button2.Text = "No account?";
            fr_button2.Click += fr_button2_Click;
            // 
            // fr_button3
            // 
            fr_button3.BackColor = Color.DarkGray;
            fr_button3.Enabled = false;
            fr_button3.ForeColor = Color.White;
            fr_button3.Location = new Point(510, 282);
            fr_button3.Name = "fr_button3";
            fr_button3.Size = new Size(125, 38);
            fr_button3.TabIndex = 13;
            fr_button3.Text = "Create";
            fr_button3.Visible = false;
            fr_button3.Click += fr_button3_Click;
            // 
            // fr_button4
            // 
            fr_button4.BackColor = Color.Transparent;
            fr_button4.ForeColor = Color.White;
            fr_button4.Location = new Point(117, 12);
            fr_button4.Name = "fr_button4";
            fr_button4.Size = new Size(99, 41);
            fr_button4.TabIndex = 14;
            fr_button4.Text = "Return";
            fr_button4.Visible = false;
            fr_button4.Click += fr_button4_Click;
            // 
            // Acc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 38);
            ClientSize = new Size(800, 450);
            Controls.Add(fr_button4);
            Controls.Add(fr_button3);
            Controls.Add(fr_button2);
            Controls.Add(fr_button1);
            Controls.Add(textBox5);
            Controls.Add(LogBox);
            Controls.Add(textBox2);
            Controls.Add(PasBox);
            Name = "Acc";
            Text = "Account";
            Load += Acc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox LogBox;
        private TextBox textBox2;
        private TextBox PasBox;
        private fr_Design.fr_button fr_button1;
        private fr_Design.fr_button fr_button2;
        private fr_Design.fr_button fr_button3;
        private fr_Design.fr_button fr_button4;
    }
}