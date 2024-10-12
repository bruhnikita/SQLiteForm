using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SQLiteWinforms
{
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=database.db;Version=3;";

        public MainForm()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadData();
            btnCreate.Click += btnCreate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnRemove.Click += btnRemove_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                        Name TEXT, 
                        Age INTEGER, 
                        City TEXT
                    )";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void LoadData()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Users";
                using (var adapter = new SQLiteDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            int age = int.TryParse(txtBoxAge.Text, out int parsedAge) ? parsedAge : 0;
            string city = txtBoxCity.Text;

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Users (Name, Age, City) VALUES (@Name, @Age, @City)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@City", city);
                    command.ExecuteNonQuery();
                }
            }
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                string name = txtBoxName.Text;
                int age = int.TryParse(txtBoxAge.Text, out int parsedAge) ? parsedAge : 0;
                string city = txtBoxCity.Text;

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Users SET Name = @Name, Age = @Age, City = @City WHERE Id = @Id";
                    using (var command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
                LoadData();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Users WHERE Id = @Id";
                    using (var command = new SQLiteCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                txtBoxAge.Text = dataGridView1.Rows[e.RowIndex].Cells["Age"].Value?.ToString();
                txtBoxCity.Text = dataGridView1.Rows[e.RowIndex].Cells["City"].Value?.ToString();
            }
        }
    }
}
