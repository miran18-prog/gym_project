using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_management_system
{
    public partial class addEmployeeForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        Emptyfields emptyfields;
        public addEmployeeForm()
        {
            InitializeComponent();
        }


        private void addEmployeeForm_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("yyyy/MM//dd");
        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int is_admin = 0;


            if (isAdmin.Checked)
            {
                is_admin = 1;
            }
            else
            {
                is_admin = 0;
            }
            if (usernameTxt.Text != "" && passwordTxt.Text != "" && firstnameTxt.Text != "" && lastnameTxt.Text != "" 
                && phoneNumberTxt.Text != "" && roleCombo.Text != "" && salaryTxt.Text != "" && date.Text != "")
            {
                connection.Close();
                connection.Open();
                command = new SqlCommand("insert into employee values('" + usernameTxt.Text + "' , '" + passwordTxt.Text + "', '" + firstnameTxt.Text + "','" +
                    lastnameTxt.Text + "' ,'" + DateTime.Now.ToShortDateString() + "','" + salaryTxt.Text + "'," +
                    "'" + roleCombo.Text + "','" + phoneNumberTxt.Text + "','" + is_admin + "')" , connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            else
            {
                emptyfields = new Emptyfields();
                emptyfields.ShowDialog();
            }

           
        }

    }
}
