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
    public partial class Language : Form
    {
        public Language()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BTNListing_Click(object sender, EventArgs e)
        {
            string sql = "SELECT   \"public\".\"language\".\"languageabb\",\r\n         \"public\".\"language\".\"languageName\",\r\n         \"public\".\"language\".\"languageID\"\r\nFROM     \"public\".\"language\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Language_Load(object sender, EventArgs e)
        {

        }

        private void BTNInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into \"language\" (\"languageID\",\"languageName\",\"languageabb\") values (@p1,@p2,@p3)", conn);

            cmd.Parameters.AddWithValue("@p1", int.Parse(TBLanguageID.Text));
            cmd.Parameters.AddWithValue("@p2", TBLanguageName.Text);
            cmd.Parameters.AddWithValue("@p3", TBLanguageAbb.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Do you agree to the Inserting ?", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from \"language\" where \"languageID\" = " + TBSerarch.Text, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
