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
    public partial class Author : Form
    {
        public Author()
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
            string sql = "SELECT   \"public\".\"author\".\"authorID\",\r\n         \"public\".\"author\".\"authorName\",\r\n         \"public\".\"author\".\"date\",\r\n         \"public\".\"author\".\"publisherID2\"\r\nFROM     \"public\".\"author\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BTNInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into \"author\" (\"authorID\",\"authorName\",\"date\",\"publisherID2\") values (@p1,@p2,@p3,@p4)", conn);

            cmd.Parameters.AddWithValue("@p1", int.Parse(TBAuthorID.Text));
            cmd.Parameters.AddWithValue("@p2", TBAuthorName.Text);
            cmd.Parameters.AddWithValue("@p3", TBAuthorDate.Text);
            cmd.Parameters.AddWithValue("@p4", int.Parse(TBPublisherID.Text));

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
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update \"author\" set \"authorName\"=@p1 ,\"date\"=@p3,\"publisherID2\"=@p4 where \"authorID\"=@p2", conn);
            cmd.Parameters.AddWithValue("@p1", TBAuthorName.Text);
            cmd.Parameters.AddWithValue("@p2", int.Parse(TBAuthorID.Text));
            cmd.Parameters.AddWithValue("@p3", TBAuthorDate.Text);
            cmd.Parameters.AddWithValue("@p4", int.Parse(TBPublisherID.Text));

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
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Delete From \"author\" Where \"authorID\"=@p2 ", conn);
            cmd.Parameters.AddWithValue("@p2", int.Parse(TBAuthorID.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Do you agree to the Deletion ?", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from \"author\" where \"authorID\" = " + TBSerarch.Text, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Author_Load(object sender, EventArgs e)
        {

        }
    }
    /*
     
    
    CREATE TABLE "public"."fiatveceza" (
	"cezaNo" serial,
	
	"eskifiat" MONEY NOT NULL,
	"yenifiat" MONEY NOT NULL,
	"degisiklikTarihi" TIMESTAMP NOT NULL,
	CONSTRAINT "PK" PRIMARY KEY ("cezaNo")
);




CREATE OR REPLACE FUNCTION "fun1trigger1"()
RETURNS TRIGGER 
AS
$$
BEGIN
    IF NEW."price" <> OLD."price" THEN
        INSERT INTO "fiatveceza"("cezaNo", "eskifiat", "yenifiat", "degisiklikTarihi")
        VALUES(3, OLD."price", NEW."price", CURRENT_TIMESTAMP::TIMESTAMP);
    END IF;

    RETURN NEW;
END;
$$
LANGUAGE "plpgsql";



CREATE TRIGGER "trgger_1"
BEFORE UPDATE ON "price"
FOR EACH ROW
EXECUTE PROCEDURE "fun1trigger1"();
     
     */



    //=---------------------------------//

    /*
     
     */
}
