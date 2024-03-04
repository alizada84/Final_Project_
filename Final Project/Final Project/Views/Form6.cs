using Final_Project.Models.Other;
using Final_Project.Models.Users;
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
    public partial class Form6 : Form
    {
        public int Id { get; set; }
        public Form6(int Id)
        {
            InitializeComponent();
            this.Id = Id;

        }

        private void btn_adddToBalance_Click(object sender, EventArgs e)
        {
            foreach (Users user in Manage.GetUsers())
            {
                if (user.Id == Id)
                {
                    user.UserBalance = float.Parse(txt_balance.Text);
                    Manage.UpdateUser(user);
                    break;
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            foreach (Users user in Manage.GetUsers())
            {
                if (user.Id == Id)
                {
                    dataBalance.DataSource = user.UserBalance;
                    break;
                }
            }
        }
    }
}
