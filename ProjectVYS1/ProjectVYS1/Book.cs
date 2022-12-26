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
    public partial class Book : Form
    {
        public Book()
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

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      

      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void BTNInsert_Click(object sender, EventArgs e)
        {

        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {

        }

        private void BTNListing_Click(object sender, EventArgs e)
        {
            string sql = "SELECT   \"public\".\"book\".\"bookID\",\r\n         \"public\".\"book\".\"bookName\",\r\n         \"public\".\"author\".\"authorName\",\r\n         \"public\".\"category\".\"categoryName\",\r\n         \"public\".\"edition\".\"editionID\",\r\n         \"public\".\"language\".\"languageName\",\r\n         \"public\".\"language\".\"languageabb\",\r\n         \"public\".\"publisher\".\"publisherName\"\r\nFROM     \"public\".\"author\" \r\nRIGHT OUTER JOIN \"public\".\"book\"  ON \"public\".\"author\".\"authorID\" = \"public\".\"book\".\"authorID\" \r\nINNER JOIN \"public\".\"category\"  ON \"public\".\"category\".\"categoryID\" = \"public\".\"book\".\"categoryID\" \r\nINNER JOIN \"public\".\"edition\"  ON \"public\".\"edition\".\"editionID\" = \"public\".\"book\".\"editionID\" \r\nINNER JOIN \"public\".\"language\"  ON \"public\".\"language\".\"languageID\" = \"public\".\"book\".\"languageID\" \r\nINNER JOIN \"public\".\"publisher\"  ON \"public\".\"publisher\".\"publisherID\" = \"public\".\"book\".\"publisherID\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BTNInsert_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into \"book\" (\"bookID\",\"authorID\",\"bookName\",\"categoryID\",\"editionID\",\"languageID\",\"publisherID\") values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn);

            cmd.Parameters.AddWithValue("@p1", int.Parse(TBBookID.Text));
            cmd.Parameters.AddWithValue("@p2", int.Parse(TBAuthorName.Text));
            cmd.Parameters.AddWithValue("@p3", TBBookName.Text);
            cmd.Parameters.AddWithValue("@p4", int.Parse(TBCategory.Text));
            cmd.Parameters.AddWithValue("@p5", int.Parse(TBEdition.Text));
            cmd.Parameters.AddWithValue("@p6", int.Parse(TBLanguage.Text));
            cmd.Parameters.AddWithValue("@p7", int.Parse(TBPublisherName.Text));

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Do you agree to the Inserting ?", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("PK Not NULL and Unique", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            conn.Close();
           // MessageBox.Show("Do you agree to the Inserting ?", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update \"book\" set \"bookName\"=@p1 ,\"authorName\"=@p3,\"categoryID\"=@p4,\"editionID\"=@p5,\"languageID\"=@p6,\"publisherName\"=@p7 where \"bookID\"=@p2", conn);
            cmd.Parameters.AddWithValue("@p1", TBBookName.Text);
            cmd.Parameters.AddWithValue("@p2", int.Parse(TBBookID.Text));
            cmd.Parameters.AddWithValue("@p3", TBAuthorName.Text);
            cmd.Parameters.AddWithValue("@p4", int.Parse(TBCategory.Text));
            cmd.Parameters.AddWithValue("@p5", int.Parse(TBEdition.Text));
            cmd.Parameters.AddWithValue("@p6", int.Parse(TBLanguage.Text));
            cmd.Parameters.AddWithValue("@p7", TBPublisherName.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Do you agree to the Updating ?", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("PK Not NULL and Unique", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            conn.Close();
          //  MessageBox.Show("Do you agree to the Updating ?", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNDelete_Click_1(object sender, EventArgs e)
        {
          


            


            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Delete From \"book\" Where \"bookID\"=@p1 ", conn);
            cmd.Parameters.AddWithValue("@p1", int.Parse(TBBookID.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Do you agree to the Deletion ?", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);




        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from \"book\" where \"bookName\" like '%" + TBSerarch.Text + "%'", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void TBBooksCounter_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Count(bookID)\r\nfrom book;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
