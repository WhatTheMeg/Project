namespace DB
{
    partial class Add
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            fr_button1 = new fr_Design.fr_button();
            fr_button2 = new fr_Design.fr_button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(544, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(35, 35, 38);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.ForeColor = SystemColors.Menu;
            textBox2.Location = new Point(12, 114);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(123, 31);
            textBox2.TabIndex = 1;
            textBox2.Text = "Name";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // fr_button1
            // 
            fr_button1.BackColor = Color.DarkGray;
            fr_button1.ForeColor = Color.White;
            fr_button1.Location = new Point(347, 441);
            fr_button1.Name = "fr_button1";
            fr_button1.Size = new Size(125, 38);
            fr_button1.TabIndex = 2;
            fr_button1.Text = "Send";
            fr_button1.Click += fr_button1_Click;
            // 
            // fr_button2
            // 
            fr_button2.BackColor = Color.DarkGray;
            fr_button2.ForeColor = Color.White;
            fr_button2.Location = new Point(12, 12);
            fr_button2.Name = "fr_button2";
            fr_button2.Size = new Size(38, 38);
            fr_button2.TabIndex = 3;
            fr_button2.Text = "←";
            fr_button2.Click += fr_button2_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(35, 35, 38);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox3.ForeColor = SystemColors.Menu;
            textBox3.Location = new Point(12, 174);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(123, 31);
            textBox3.TabIndex = 4;
            textBox3.Text = "Article";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 66);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(544, 27);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(35, 35, 38);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox5.ForeColor = SystemColors.InactiveBorder;
            textBox5.Location = new Point(12, 62);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(123, 31);
            textBox5.TabIndex = 6;
            textBox5.Text = "Type";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(141, 180);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(544, 216);
            textBox6.TabIndex = 7;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 38);
            ClientSize = new Size(800, 532);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(fr_button2);
            Controls.Add(fr_button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Add";
            StartPosition = FormStartPosition.Manual;
            Text = "Form3";
            Load += Add_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private fr_Design.fr_button fr_button1;
        private fr_Design.fr_button fr_button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}