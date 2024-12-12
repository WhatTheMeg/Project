
using Microsoft.Data.Sqlite;
using System.Security.Cryptography.X509Certificates;

namespace DB
{
    partial class Main
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            fr_button5 = new fr_Design.fr_button();
            pictureBox1 = new PictureBox();
            textBox4 = new TextBox();
            fr_button1 = new fr_Design.fr_button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(48, 58);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(520, 636);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // fr_button5
            // 
            fr_button5.BackColor = Color.FromArgb(35, 35, 38);
            fr_button5.ForeColor = Color.White;
            fr_button5.Location = new Point(12, 12);
            fr_button5.Name = "fr_button5";
            fr_button5.Size = new Size(79, 38);
            fr_button5.TabIndex = 8;
            fr_button5.Text = "☰";
            fr_button5.Click += fr_button5_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.searc;
            pictureBox1.Location = new Point(521, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Menu;
            textBox4.Location = new Point(352, 18);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(166, 27);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // fr_button1
            // 
            fr_button1.BackColor = Color.DarkGray;
            fr_button1.ForeColor = Color.White;
            fr_button1.Location = new Point(26, 789);
            fr_button1.Name = "fr_button1";
            fr_button1.Size = new Size(125, 38);
            fr_button1.TabIndex = 11;
            fr_button1.Text = "-";
            fr_button1.Visible = false;
            fr_button1.Click += fr_button1_Click_1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(35, 35, 38);
            ClientSize = new Size(582, 853);
            Controls.Add(fr_button1);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
            Controls.Add(fr_button5);
            Controls.Add(flowLayoutPanel1);
            MaximumSize = new Size(600, 900);
            MinimumSize = new Size(600, 900);
            Name = "Main";
            StartPosition = FormStartPosition.Manual;
            Text = "Mini Wiki";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    

        }

#endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private fr_Design.fr_button fr_button5;
        private PictureBox pictureBox1;
        private TextBox textBox4;
        private fr_Design.fr_button fr_button1;
    }
}
