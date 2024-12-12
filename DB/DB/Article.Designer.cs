namespace DB
{
    partial class Article
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
            fr_button3 = new fr_Design.fr_button();
            fr_button4 = new fr_Design.fr_button();
            fr_button5 = new fr_Design.fr_button();
            textBox3 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.FromArgb(35, 35, 38);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(23, 60);
            textBox1.MinimumSize = new Size(832, 320);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(832, 351);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(35, 35, 38);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.ForeColor = SystemColors.Menu;
            textBox2.Location = new Point(201, 12);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(478, 31);
            textBox2.TabIndex = 2;
            textBox2.TabStop = false;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // fr_button1
            // 
            fr_button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            fr_button1.BackColor = Color.DarkGray;
            fr_button1.ForeColor = Color.White;
            fr_button1.Location = new Point(730, 430);
            fr_button1.Name = "fr_button1";
            fr_button1.Size = new Size(125, 38);
            fr_button1.TabIndex = 3;
            fr_button1.Text = "Edit";
            fr_button1.Click += fr_button1_Click;
            // 
            // fr_button2
            // 
            fr_button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            fr_button2.BackColor = Color.DarkGray;
            fr_button2.ForeColor = Color.White;
            fr_button2.Location = new Point(730, 430);
            fr_button2.Name = "fr_button2";
            fr_button2.Size = new Size(125, 38);
            fr_button2.TabIndex = 4;
            fr_button2.Text = "Save";
            fr_button2.Visible = false;
            fr_button2.Click += fr_button2_Click;
            // 
            // fr_button3
            // 
            fr_button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            fr_button3.BackColor = Color.DarkGray;
            fr_button3.ForeColor = Color.White;
            fr_button3.Location = new Point(599, 430);
            fr_button3.Name = "fr_button3";
            fr_button3.Size = new Size(125, 38);
            fr_button3.TabIndex = 5;
            fr_button3.Text = "Cancel";
            fr_button3.Visible = false;
            fr_button3.Click += fr_button3_Click;
            // 
            // fr_button4
            // 
            fr_button4.BackColor = Color.DarkGray;
            fr_button4.ForeColor = Color.White;
            fr_button4.Location = new Point(12, 12);
            fr_button4.Name = "fr_button4";
            fr_button4.Size = new Size(38, 38);
            fr_button4.TabIndex = 6;
            fr_button4.Text = "←";
            fr_button4.Click += fr_button4_Click;
            // 
            // fr_button5
            // 
            fr_button5.BackColor = Color.DarkGray;
            fr_button5.ForeColor = Color.White;
            fr_button5.Location = new Point(23, 430);
            fr_button5.Name = "fr_button5";
            fr_button5.Size = new Size(125, 38);
            fr_button5.TabIndex = 7;
            fr_button5.Text = "Remove";
            fr_button5.Click += fr_button5_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(35, 35, 38);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 10F);
            textBox3.ForeColor = SystemColors.Menu;
            textBox3.Location = new Point(690, 21);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(160, 23);
            textBox3.TabIndex = 8;
            textBox3.TabStop = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(640, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 9;
            label1.Text = "Type:";
            label1.Click += label1_Click_1;
            // 
            // Article
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 38);
            ClientSize = new Size(867, 480);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(fr_button5);
            Controls.Add(fr_button4);
            Controls.Add(fr_button3);
            Controls.Add(fr_button2);
            Controls.Add(fr_button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "Article";
            StartPosition = FormStartPosition.Manual;
            Text = "Mini Wiki";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private fr_Design.fr_button fr_button1;
        private fr_Design.fr_button fr_button2;
        private fr_Design.fr_button fr_button3;
        private fr_Design.fr_button fr_button4;
        private fr_Design.fr_button fr_button5;
        private TextBox textBox3;
        private Label label1;
    }
}