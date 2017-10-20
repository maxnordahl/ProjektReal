using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            
        }
    }
}
