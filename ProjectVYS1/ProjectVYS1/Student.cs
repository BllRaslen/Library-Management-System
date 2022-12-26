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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Click(object sender, EventArgs e)
        {
            
                Form1 newForm = new Form1();
                newForm.Show();
                this.Hide();
            }

        private void Student_Load_1(object sender, EventArgs e)
        {

        }

        private void BTNBuyer_Click(object sender, EventArgs e)
        {
            Buyer newForm = new Buyer();
            newForm.Show();
            this.Hide();
        }

        private void BTNBorrower_Click(object sender, EventArgs e)
        {
            Borrower newForm = new Borrower();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
