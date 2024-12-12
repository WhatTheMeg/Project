using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace DB
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void fr_button2_Click(object sender, EventArgs e)
        {
            Main FirstForm = new Main();
            FirstForm.Location = this.Location;

            FirstForm.Show();

            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void fr_button1_Click(object sender, EventArgs e)
        {
            string articleTitle = textBox1.Text.Trim();
            string articleContent = textBox6.Text.Trim();
            string articleType = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(articleTitle) ||
                string.IsNullOrWhiteSpace(articleContent) ||
                string.IsNullOrWhiteSpace(articleType))
            {
                MessageBox.Show("Fields are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Data Source=data.db";
                int nextId = 1;

                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    string getMaxIdQuery = "SELECT MAX(id) FROM wiki";
                    using (var command = new SqliteCommand(getMaxIdQuery, connection))
                    {
                        var result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            nextId = Convert.ToInt32(result) + 1;
                        }
                    }

                    // SQL-запрос для вставки
                    string insert = "INSERT INTO wiki (id, name, content, type) VALUES (@Id, @Name, @Content, @Type)";
                    using (var command = new SqliteCommand(insert, connection))
                    {
                        command.Parameters.AddWithValue("@Id", nextId);
                        command.Parameters.AddWithValue("@Name", articleTitle);
                        command.Parameters.AddWithValue("@Content", articleContent);
                        command.Parameters.AddWithValue("@Type", articleType);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data succsesfully saved");

                textBox1.Clear();
                textBox6.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
