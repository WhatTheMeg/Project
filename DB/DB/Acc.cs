using fr_Design;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB
{
    public partial class Acc : Form
    {
        public Acc()
        {
            InitializeComponent();
        }

        private void fr_button1_Click(object sender, EventArgs e)
        {
            string Login = LogBox.Text.Trim();
            string Password = PasBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(Login) ||
                string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Login box or Password box is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Data Source=data.db";

                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    string insert = "SELECT * FROM accounts WHERE login = @Log AND password = @Pass";
                    using (var command = new SqliteCommand(insert, connection))
                    {
                        command.Parameters.AddWithValue("@Log", Login);
                        command.Parameters.AddWithValue("@Pass", Password);

                        using var reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string? L = reader["login"].ToString();
                            string? P = reader["password"].ToString();
                            if (L == Login && P == Password)
                            {
                                MessageBox.Show("Login Succsesfull!", "Succes!");

                                Main FirstForm = new Main();
                                FirstForm.Location = this.Location;

                                FirstForm.Show();

                                this.Hide();
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


        private void Acc_Load(object sender, EventArgs e)
        {
        }

        private void PasBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fr_button2_Click(object sender, EventArgs e)
        {
            fr_button1.Visible = false;
            fr_button2.Visible = false;
            fr_button3.Visible = true;
            fr_button4.Visible = true;

            fr_button1.Enabled = false;
            fr_button2.Enabled = false;
            fr_button3.Enabled = true;
            fr_button4.Enabled = true;
        }

        private void fr_button4_Click(object sender, EventArgs e)
        {
            fr_button1.Visible = true;
            fr_button2.Visible = true;
            fr_button3.Visible = false;
            fr_button4.Visible = false;

            fr_button1.Enabled = true;
            fr_button2.Enabled = true;
            fr_button3.Enabled = false;
            fr_button4.Enabled = false;
        }

        private void fr_button3_Click(object sender, EventArgs e)
        {
            string Login = LogBox.Text.Trim();
            string Password = PasBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(Login) ||
                string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Login box or Password box is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Data Source=data.db";
                int nextId = 1;

                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    string getMaxIdQuery = "SELECT MAX(id) FROM accounts";
                    using (var command = new SqliteCommand(getMaxIdQuery, connection))
                    {
                        var result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            nextId = Convert.ToInt32(result) + 1;
                        }
                    }

                    string insert = "INSERT INTO accounts (id, login, password, admin) VALUES (@Id, @Log, @Pass, 'NO')";
                    using (var command = new SqliteCommand(insert, connection))
                    {
                        command.Parameters.AddWithValue("@Id", nextId);
                        command.Parameters.AddWithValue("@Log", Login);
                        command.Parameters.AddWithValue("@Pass", Password);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("New account registered!", "Succes!");

                LogBox.Clear();
                PasBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login is already taken, choose another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
