using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVYS1
{
    public partial class Publisher : Form
    {
        public Publisher()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=NewLibrary; user ID=postgres; password=Bilal2002");


        private void BTN_Click(object sender, EventArgs e)
        {

            Admin newForm = new Admin();
            newForm.Show();
            this.Hide();
        }

        private void BTNListing_Click(object sender, EventArgs e)
        {
            string sql = "SELECT   \"public\".\"publisher\".\"publisherID\",\r\n         \"public\".\"publisher\".\"publisherName\",\r\n         \"public\".\"publisher\".\"publisherAdress\",\r\n         \"public\".\"publisher\".\"publisherMail\"\r\nFROM     \"public\".\"publisher\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Publisher_Load(object sender, EventArgs e)
        {

        }

        private void BTNInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into \"publisher\" (\"publisherID\",\"publisherName\",\"publisherAdress\",\"publisherMail\") values (@p1,@p2,@p3,@p4)", conn);

            cmd.Parameters.AddWithValue("@p1", int.Parse(TBPublisherID.Text));
            cmd.Parameters.AddWithValue("@p2", TBPublisherName.Text);
            cmd.Parameters.AddWithValue("@p3", TBPublisherAdress.Text);
            cmd.Parameters.AddWithValue("@p4", TBPublisherMail.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Do you agree to the Inserting ?", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            catch (Exception ex) {
                MessageBox.Show("PK Not NULL and Unique", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            conn.Close();
            //MessageBox.Show("Do you agree to the Inserting ?", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update \"publisher\" set \"publisherName\"=@p1 ,\"publisherAdress\"=@p3,\"publisherMail\"=@p4 where \"publisherID\"=@p2", conn);
            cmd.Parameters.AddWithValue("@p1", TBPublisherName.Text);
            cmd.Parameters.AddWithValue("@p3", TBPublisherAdress.Text);
            cmd.Parameters.AddWithValue("@p4", TBPublisherMail.Text);
            cmd.Parameters.AddWithValue("@p2", int.Parse(TBPublisherID.Text));

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Do you agree to the Updating ?", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Delete From \"publisher\" Where \"publisherID\"=@p2 ", conn);
            cmd.Parameters.AddWithValue("@p2", int.Parse(TBPublisherID.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Do you agree to the Deletion ?", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
             conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from \"publisher\" where \"publisherID\" = " + TBSearch.Text, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
