using System;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;
using fr_Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Drawing.Text;

namespace DB
{
    public partial class Main : Form
    {

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private bool isMenuOpen = false;
        private Panel panelMenu = new Panel();
        private Panel overlayPanel = new Panel();
        private fr_button buttonAdd = new fr_button();
        public Main()
        {
            InitializeComponent();

            //titlebar
            titlebar titleBar = new titlebar();
            titleBar.Dock = DockStyle.Top;
            Controls.Add(titleBar);

            //Panel Initialize
            panelMenu.Width = 0;
            panelMenu.BringToFront();
            panelMenu.Height = this.Height;
            panelMenu.BackColor = Color.FromArgb(35, 35, 38); //Color
            panelMenu.Dock = DockStyle.Left;
            this.Controls.Add(panelMenu);

            panelMenu.Paint += PanelMenu_Paint;
            this.Controls.Add(panelMenu);

            //Timer
            timer.Interval = 10;
            timer.Tick += Timer_Tick;

            //Database Load
            LoadDBinfo();

        }

        private void InitializeMenuButtons()
        {
            //Adf button
            buttonAdd.Text = "Add";
            buttonAdd.Size = new Size(80, 40);
            buttonAdd.Location = new Point(10, 50);
            buttonAdd.BackColor = Color.Gray;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Click += buttonAdd_Click;

            panelMenu.Controls.Add(buttonAdd);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add AddForm = new Add();
            AddForm.Location = this.Location;
            AddForm.Show();
            this.Hide();
        }


        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            isMenuOpen = !isMenuOpen;
            overlayPanel.Visible = isMenuOpen;
            overlayPanel.BringToFront();
            panelMenu.BringToFront();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isMenuOpen)
            {
                panelMenu.Width += 10;
                if (panelMenu.Width >= 100)
                {
                    timer.Stop();
                    panelMenu.BringToFront();
                    fr_button5.BringToFront();
                    InitializeMenuButtons();
                    buttonAdd.BringToFront();
                }
            }
            else
            {
                panelMenu.Width -= 10;
                if (panelMenu.Width <= 0)
                {
                    this.BackColor = Color.FromArgb(35, 35, 38);
                    timer.Stop();


                }
            }
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {
            if (panelMenu.Width >= 100)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (Pen pen = new Pen(Color.Black, 1))
                {

                    e.Graphics.DrawLine(pen, 0, 0, panelMenu.Width - 1, 0);
                    e.Graphics.DrawLine(pen, 0, 0, 0, panelMenu.Height - 1);
                    e.Graphics.DrawLine(pen, panelMenu.Width - 1, 0, panelMenu.Width - 1, panelMenu.Height - 1);
                    e.Graphics.DrawLine(pen, 0, panelMenu.Height - 1, panelMenu.Width - 1, panelMenu.Height - 1);
                }
            }
        }



        string connectionString = "Data Source=data.db;";
        private void LoadDBinfo()
        {
            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT id, name FROM wiki ORDER BY id";
                    using (var command = new SqliteCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int btnId = reader.GetInt32(0);
                                Console.WriteLine(btnId);

                                string buttonName = reader.GetString(1);
                                fr_button button = new fr_button();
                                button.Height = 100;
                                button.Width = 100;
                                button.Tag = btnId;
                                button.Text = buttonName;

                                button.BackColor = ColorTranslator.FromHtml("#2D2E30");
                                flowLayoutPanel1.Controls.Add(button);
                                button.Click += new EventHandler(fr_button3_Click);

                            }
                        }
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDBinfoSearch()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT id, name FROM wiki WHERE type LIKE @text OR name LIKE @text OR content LIKE @text ORDER BY id";
                    using (var command = new SqliteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@text", "%" + textBox4.Text + "%");
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int btnId = reader.GetInt32(0);
                                Console.WriteLine(btnId);

                                string buttonName = reader.GetString(1);
                                fr_button button = new fr_button();
                                button.Height = 100;
                                button.Width = 100;
                                button.Tag = btnId;
                                button.Text = buttonName;

                                button.BackColor = ColorTranslator.FromHtml("#2D2E30");
                                flowLayoutPanel1.Controls.Add(button);
                                button.Click += new EventHandler(fr_button3_Click);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fr_button5_Click_1(object sender, EventArgs e)
        {
            isMenuOpen = !isMenuOpen;
            timer.Start();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fr_button1_Click(object sender, EventArgs e)
        {
        }

        private void fr_button2_Click(object sender, EventArgs e)
        {
            LoadDBinfoSearch();
        }

        private void fr_button3_Click(object sender, EventArgs e)
        {
            fr_button button = (fr_button)sender;
            int ts = (int)button.Tag;

            Article secondForm = new(ts);
            secondForm.Location = this.Location;

            secondForm.Show();
            this.Hide();
        }


        private void fr_button5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void fr_button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            LoadDBinfoSearch();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fr_button1_Click_1(object sender, EventArgs e)
        {
            Acc FirstForm = new Acc();
            FirstForm.Location = this.Location;

            FirstForm.Show();

            this.Hide();
        }
    }
}
