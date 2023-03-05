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
    public partial class LoginForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        dashboard dashboard;
        SqlCommand command;
        SqlDataReader dataReader;
        public LoginForm()
        {
            InitializeComponent();


        }



        private void unlock_Click(object sender, EventArgs e)
        {

        }

        private void locked_Click(object sender, EventArgs e)
        {
            if (passwordTxt.UseSystemPasswordChar == true)
            {
                // Password is currently hidden, so show it
                passwordTxt.UseSystemPasswordChar = false;
                locked.Image = Properties.Resources.lock_open_svgrepo_com;
            }
            else
            {
                // Password is currently shown, so hide it
                passwordTxt.UseSystemPasswordChar = true;
                locked.Image = Properties.Resources.lock_svgrepo_com;

            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            connection.Close();
            connection.Open();
            command = new SqlCommand("select * from Employee where emp_username='"+ usernameTxt.Text+"' and Emp_password ='"+passwordTxt.Text+"' ", connection);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                dashboard = new dashboard(int.Parse(dataReader["Emp_id"].ToString()));
                this.Hide();

                dashboard.ShowDialog();
            }
            else if(usernameTxt.Text=="" || passwordTxt.Text == "")
            {
                snackbatPanelLabel.Text="please fill all fields";
                snackbarTimer.Start();
            }
            else
            {
                snackbarTimer.Start();
                snackbatPanelLabel.Text = "Invailed User!";
            }
            connection.Close();

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool collapsed = true;

        private void snackbarTimer_Tick(object sender, EventArgs e)
        {
            if (collapsed)
            {
                snackbarPanel.Height += 3;

                if (snackbarPanel.Height >= 50)
                {
                    snackbarTimer.Stop();
                    collapsed = false;
                }
            }
            else
            {
                snackbarPanel.Height -= 3;

                if (snackbarPanel.Height == 0)
                {
                    snackbarTimer.Stop();
                    collapsed = true;

                }

            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            snackbarPanel.Height = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (collapsed == false)
            {
                snackbarTimer.Start();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (collapsed == false)
            {
                snackbarTimer.Start();
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (collapsed == false)
            {
                snackbarTimer.Start();
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (collapsed == false)
            {
                snackbarTimer.Start();
                //}
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
