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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BTNPublisher_Click(object sender, EventArgs e)
        {
            Publisher newForm = new Publisher();
            newForm.Show();
            this.Hide();
        }

        private void BTNLanguage_Click(object sender, EventArgs e)
        {
            Language newForm = new Language();
            newForm.Show();
            this.Hide();
        }

        private void BTNAuthor_Click(object sender, EventArgs e)
        {
            Author newForm = new Author();
            newForm.Show();
            this.Hide();
        }

        private void BTNBook_Click(object sender, EventArgs e)
        {

            Book newForm = new Book();
            newForm.Show();
            this.Hide();
        }

        private void BTNAllInformation_Click(object sender, EventArgs e)
        {
            
            AllInformation newForm = new AllInformation();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fonkisyonlar newForm = new fonkisyonlar();
            newForm.Show();
            this.Hide();
        }
    }
}
