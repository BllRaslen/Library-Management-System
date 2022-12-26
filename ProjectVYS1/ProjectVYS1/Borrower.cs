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
    public partial class Borrower : Form
    {
        public Borrower()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            Student newForm = new Student();
            newForm.Show();
            this.Hide();
        }

        private void Borrower_Load(object sender, EventArgs e)
        {

        }
    }
}
