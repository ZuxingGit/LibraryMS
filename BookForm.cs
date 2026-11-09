using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
            displayBooks();
        }

        string connString = ConfigurationManager.ConnectionStrings["libraryConnection"].ConnectionString;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void displayBooks()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Book";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Book VALUES (@title, @author, @isbn, @publisher, @pubyear)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@title", titlebox.Text);
                cmd.Parameters.AddWithValue("@author", authorbox.Text);
                cmd.Parameters.AddWithValue("@isbn", ISBNbox.Text);
                cmd.Parameters.AddWithValue("@publisher", publisherbox.Text);
                cmd.Parameters.Add("@pubyear", SqlDbType.DateTime).Value = dateTimePicker1.Value;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                
                MessageBox.Show("Book added successfully!");
                displayBooks();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE Book SET title=@title, author=@author, ISBN=@isbn, publisher=@publisher, publish_year=@pubyear WHERE book_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", updatetext.Text);
                cmd.Parameters.AddWithValue("@title", titlebox.Text);
                cmd.Parameters.AddWithValue("@author", authorbox.Text);
                cmd.Parameters.AddWithValue("@isbn", ISBNbox.Text);
                cmd.Parameters.AddWithValue("@publisher", publisherbox.Text);
                cmd.Parameters.Add("@pubyear", SqlDbType.DateTime).Value = dateTimePicker1.Value;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Book updated successfully!");
                displayBooks();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "DELETE FROM Book WHERE book_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", updatetext.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Book deleted successfully!");
                displayBooks();
            }
        }
    }
}
