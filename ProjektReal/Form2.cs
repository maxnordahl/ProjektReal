﻿using System;
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
    public partial class Form2 : Form
    {
        public object Category { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }


        private void btnHomePage_Click(object sender, EventArgs e)
        {
            Presentation home = new Presentation();
            home.Show();
        }

        private void lstBoxCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //fylla lstBoxCate 
            lstBoxCate.DataSource = Category;
        }
    }
}
