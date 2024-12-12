using fr_Design;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB
{
    public partial class Article : Form
    {
        public static string connectionString = "Data Source=data.db;";

        public Article(int id)
        {
            InitializeComponent();
            Console.WriteLine($"ID = {id}");
            ReadDB(id);

        }

        private void ReadDB(int id)
        {
            var sql = "SELECT content, name, type FROM wiki WHERE id = @id";
            int nedid = id;
            Console.WriteLine($"NEDID = {nedid}");


            try
            {

                using var connection = new SqliteConnection(connectionString);
                connection.Open();

                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@id", nedid);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                {

                    string text = reader["content"].ToString();
                    string title = reader["name"].ToString();
                    string type = reader["type"].ToString();

                    textBox1.Text = text;
                    textBox2.Text = title;
                    textBox3.Text = type;

                    string temp = textBox2.Text;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (SqliteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string tempart;
        private void Form2_Load(object sender, EventArgs e)
        {
            tempart = textBox2.Text.Trim();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void fr_button1_Click(object sender, EventArgs e)
        {
            tempart = textBox2.Text.Trim();
            fr_button1.Visible = false;
            fr_button1.Enabled = false;

            fr_button3.Visible = true;
            fr_button2.Visible = true;



            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;

        }


        private void fr_button2_Click(object sender, EventArgs e)
        {
            string articleTitle = textBox2.Text.Trim();
            string articleContent = textBox1.Text.Trim();
            string articleType = textBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(articleTitle) ||
                string.IsNullOrWhiteSpace(articleContent))
            {
                MessageBox.Show("Fields are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Data Source=data.db";

                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    string ID = "SELECT id FROM wiki WHERE name = @name";
                    using var getID = new SqliteCommand(ID, connection);
                    var id = getID.Parameters.AddWithValue("@name", tempart);
                    var result = getID.ExecuteScalar();

                    Console.WriteLine($"NAME = {articleTitle}");
                    Console.WriteLine($"ROW ID = {result}");
                    int R_Id = Convert.ToInt32(result);


                    string insert = "UPDATE wiki SET name = @Name, content = @Content, type = @Type WHERE id = @id";
                    using (var command = new SqliteCommand(insert, connection))
                    {

                        command.Parameters.AddWithValue("@Name", articleTitle);
                        command.Parameters.AddWithValue("@Content", articleContent);
                        command.Parameters.AddWithValue("@Type", articleType);
                        command.Parameters.AddWithValue("@id", Convert.ToInt32(result));


                        command.ExecuteNonQuery();
                    }


                }

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                MessageBox.Show("Data succesfully saved!");
                fr_button1.Visible = true;
                fr_button1.Enabled = true;
                fr_button3.Visible = false;
                fr_button2.Visible = false;







            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error!: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void fr_button3_Click(object sender, EventArgs e)
        {
            fr_button1.Visible = true;
            fr_button1.Enabled = true;

            fr_button3.Visible = false;
            fr_button2.Visible = false;

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void fr_button4_Click(object sender, EventArgs e)
        {
            Main FirstForm = new Main();
            FirstForm.Location = this.Location;

            FirstForm.Show();

            this.Hide();
        }
        private void fr_button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = "Data Source=data.db";

                    using (var connection = new SqliteConnection(connectionString))
                    {
                        connection.Open();

                        string ID = "SELECT id FROM wiki WHERE name = @name";
                        using (var getID = new SqliteCommand(ID, connection))
                        {
                            getID.Parameters.AddWithValue("@name", tempart);
                            var result = getID.ExecuteScalar();

                            if (result != null)
                            {
                                int R_Id = Convert.ToInt32(result);

                                string delete = "DELETE FROM wiki WHERE id = @id";
                                using (var command = new SqliteCommand(delete, connection))
                                {
                                    command.Parameters.AddWithValue("@id", R_Id);
                                    command.ExecuteNonQuery();

                                    MessageBox.Show($"Article with ID {R_Id} was deleted.", "ОK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Main FirstForm = new Main();

                                    FirstForm.Show();

                                    this.Hide();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Article is not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
