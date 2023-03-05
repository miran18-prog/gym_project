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
    public partial class deleteEmployee : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        string id;
        public deleteEmployee(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("delete from employee where emp_id='" + id + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
