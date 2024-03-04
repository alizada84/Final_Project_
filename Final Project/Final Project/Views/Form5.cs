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
    public partial class Form5 : Form
    {
        public int Id { get; set; }
        public Form5(int Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void btn_shop_Click(object sender, EventArgs e)
        {

        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(Id);
            form6.ShowDialog();

            this.Close();
        }
    }
}
