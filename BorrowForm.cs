using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LibraryMS
{
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
            displayMembers();
            displayBooks();
            displayBorrows();
        }

        string connString = ConfigurationManager.ConnectionStrings["libraryConnection"].ConnectionString;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {

        }
        private void displayBooks()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Book";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Book");
                bookcombo.DataSource = ds.Tables["Book"];
                bookcombo.DisplayMember = "title";
                bookcombo.ValueMember = "book_id";
            }
        }
        private void displayMembers()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Member";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Member");
                membercombo.DataSource = ds.Tables["Member"];
                membercombo.DisplayMember = "full_name";
                membercombo.ValueMember = "member_id";
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Borrow (member_id, book_id, borrow_date, return_status) VALUES (@member_id, @book_id, @borrow_date, @return_status)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@member_id", membercombo.SelectedValue);
                cmd.Parameters.AddWithValue("@book_id", bookcombo.SelectedValue);
                cmd.Parameters.AddWithValue("@borrow_date", DateTime.Now);
                cmd.Parameters.AddWithValue("@return_status", "Borrowed");

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Borrow record saved successfully.");
                displayBorrows();
            }
        }

        private void displayBorrows()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Borrow";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Borrow");
                borrowDataGridView.DataSource = ds.Tables["Borrow"];
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE Borrow set member_id=@member_id, book_id=@book_id WHERE borrow_id=@borrow_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@member_id", membercombo.SelectedValue);
                cmd.Parameters.AddWithValue("@book_id", bookcombo.SelectedValue);
                cmd.Parameters.AddWithValue("@borrow_id", borrowid.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Borrow record updated successfully.");
                displayBorrows();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "DELETE FROM Borrow WHERE borrow_id=@borrow_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@borrow_id", borrowid.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Borrow record deleted successfully.");
                displayBorrows();
            }
        }
    }
}
