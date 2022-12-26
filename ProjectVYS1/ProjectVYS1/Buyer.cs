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
    public partial class Buyer : Form
    {
        public Buyer()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=NewLibrary; user ID=postgres; password=Bilal2002");


        private void BTNListing_Click(object sender, EventArgs e)
        {
            string sql = "SELECT   \"public\".\"student\".\"studentID\",\r\n         \"public\".\"student\".\"buyerID\",\r\n         \"public\".\"student\".\"studentName\",\r\n         \"public\".\"student\".\"studentDate\",\r\n         \"public\".\"student\".\"StudentPhoneNo\",\r\n         \"public\".\"buyer\".\"moneyID\",\r\n         \"public\".\"buyer\".\"studentID\"\r\nFROM     \"public\".\"student\" \r\nLEFT OUTER JOIN \"public\".\"buyer\"  ON \"public\".\"student\".\"studentID\" = \"public\".\"buyer\".\"studentID\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {

            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Delete From \"buyer\" Where \"buyerID\"=@p1 ", conn);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TBStudentID.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Do you agree to the Deletion ?", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        }

        private void BTNInsert_Click(object sender, EventArgs e)
        {
          
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
         
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
          

        }

        private void BTN_Click(object sender, EventArgs e)
        {
            Student newForm = new Student();
            newForm.Show();
            this.Hide();
        }

        private void Buyer_Load(object sender, EventArgs e)
        {

        }
    }
    }