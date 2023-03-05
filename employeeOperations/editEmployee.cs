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
    public partial class editEmployee : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        string id;
        public editEmployee(string id)
        {
            InitializeComponent();
            this.id = id;

            connection.Close();
            connection.Open();
            command = new SqlCommand("select * from employee where emp_ID ='" + id + "'", connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                firstnameTxt.Text = reader["emp_First_Name"].ToString();
                lastnameTxt.Text = reader["emp_Last_Name"].ToString();
                usernameTxt.Text = reader["Emp_username"].ToString();
                salaryTxt.Text = reader["emp_salary"].ToString();
                phonenumberTxt.Text = reader["emp_phone_number"].ToString();
                passwordTxt.Text = reader["emp_password"].ToString();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editEmployee_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("Update Employee set emp_username='" + usernameTxt.Text + "', emp_last_name='" + lastnameTxt.Text + "', emp_first_name='" + firstnameTxt.Text + "' ,emp_salary='" + salaryTxt.Text + "', emp_phone_number='" + phonenumberTxt.Text + "', Emp_Role='" + filterComobox.Text + "'  where emp_id='" + id + "'", connection);
            command.ExecuteReader();
            connection.Close();

            this.Close();
        }

        private void filterComobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
