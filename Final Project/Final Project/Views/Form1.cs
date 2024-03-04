using Final_Project.Models.Other;
using Final_Project.Models.Users;
using Final_Project.Views;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public int Id { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                List<Users> users = Manage.GetUsers();
                foreach (Users user in users)
                {
                    if (user.UserName == txtBox_username.Text && user.Id.ToString() == txtBox_id.Text)
                    {
                        Id = user.Id;

                        if (user.RoleId == 1)
                        {
                            Form2 form2 = new Form2();
                            form2.ShowDialog();

                            this.Close();
                        }
                        else if (user.RoleId == 2)
                        {
                            Form2 form2 = new Form2();
                            form2.ShowDialog();

                            this.Close();
                        }
                    }
                    else
                        MessageBox.Show("Incorrect Username or Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }


    }
}