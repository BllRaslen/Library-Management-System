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
    public partial class AllInformation : Form
    {
        public AllInformation()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNListing_Click(object sender, EventArgs e)
        {
            string sql = "SELECT   \"public\".\"book\".\"bookID\",\r\n         \"public\".\"book\".\"bookName\",\r\n         \"public\".\"category\".\"categoryName\",\r\n         \"public\".\"edition\".\"editionID\",\r\n         \"public\".\"language\".\"languageName\",\r\n         \"public\".\"language\".\"languageabb\",\r\n         \"public\".\"language\".\"countryID\",\r\n         \"public\".\"place\".\"placeAdress\",\r\n         \"public\".\"price\".\"price\",\r\n         \"public\".\"author\".\"publisherID\"\r\nFROM     \"public\".\"author\" \r\nRIGHT OUTER JOIN \"public\".\"book\"  ON \"public\".\"author\".\"authorID\" = \"public\".\"book\".\"authorID\" \r\nLEFT OUTER JOIN \"public\".\"category\"  ON \"public\".\"category\".\"categoryID\" = \"public\".\"book\".\"categoryID\" \r\nLEFT OUTER JOIN \"public\".\"edition\"  ON \"public\".\"edition\".\"editionID\" = \"public\".\"book\".\"editionID\" \r\nLEFT OUTER JOIN \"public\".\"language\"  ON \"public\".\"language\".\"languageID\" = \"public\".\"book\".\"languageID\" \r\nLEFT OUTER JOIN \"public\".\"place\"  ON \"public\".\"place\".\"placeID\" = \"public\".\"book\".\"placeID\" \r\nLEFT OUTER JOIN \"public\".\"price\"  ON \"public\".\"price\".\"priceID\" = \"public\".\"book\".\"priceID\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AllInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
