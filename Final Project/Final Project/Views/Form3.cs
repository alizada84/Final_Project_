﻿using Final_Project.Models.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Views
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataProducts.DataSource = Manage.GetProducts();
        }

        private void btn_Add1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update1_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete1_Click(object sender, EventArgs e)
        {

        }
    }
}
