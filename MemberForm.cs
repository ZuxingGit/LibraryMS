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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
            displayMembers();
        }

        string connString = ConfigurationManager.ConnectionStrings["libraryConnection"].ConnectionString;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayMembers()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Member";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Member VALUES (@name, @phone, @email, @address, @join)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", fullnamebox.Text);
                cmd.Parameters.AddWithValue("@phone", phonebox.Text);
                cmd.Parameters.AddWithValue("@email", emailbox.Text);
                cmd.Parameters.AddWithValue("@address", addressbox.Text);
                cmd.Parameters.AddWithValue("@join", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
               
                MessageBox.Show("Member added successfully!");
                displayMembers();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE Member SET full_name = @name, phone = @phone, email = @email, address = @address, join_date = @join WHERE member_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", updatetext.Text);
                cmd.Parameters.AddWithValue("@name", fullnamebox.Text);
                cmd.Parameters.AddWithValue("@phone", phonebox.Text);
                cmd.Parameters.AddWithValue("@email", emailbox.Text);
                cmd.Parameters.AddWithValue("@address", addressbox.Text);
                cmd.Parameters.AddWithValue("@join", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Member updated successfully!");
                displayMembers();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "DELETE FROM Member WHERE member_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", updatetext.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Member deleted successfully!");
                displayMembers();
            }
        }
    }
}
