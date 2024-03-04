using Final_Project.Models.Other;
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
    public partial class Form7 : Form
    {
        public int Id { get; set; }
        public Form7(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataProducts.DataSource = Manage.GetProducts();
        }
    }
}
