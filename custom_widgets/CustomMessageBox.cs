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

    public partial class CustomMessageBox : Form
    {
        LoginForm login;
        string id;

        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        public CustomMessageBox(string message , string i)
        {
            InitializeComponent();
            this.guna2Button3.Text = message;
            this.id = i;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            this.Close();
         
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
