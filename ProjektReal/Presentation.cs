using System;
using System.Windows.Forms;

namespace ProjektReal
{
    public partial class Presentation : Form
    {
        public Presentation()
        {
            InitializeComponent();
        }

        private void lstBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPren_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            
        }

        private void btnMyPage_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblURL_Click(object sender, EventArgs e)
        {

        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;

        }
    }
}
