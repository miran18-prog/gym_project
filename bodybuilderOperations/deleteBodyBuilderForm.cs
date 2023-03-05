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
    public partial class deleteBodyBuilderForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        string id;
        public deleteBodyBuilderForm( string i)
        {
            InitializeComponent();
            this.id = i;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("delete from Exercises where Exercises_Id='" + id + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            connection.Open();
            command = new SqlCommand("delete from Body_Builder where BD_ID='" + id + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
