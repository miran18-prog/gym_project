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
    public partial class deleteExersice : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        string exName;
        public deleteExersice(string exName)
        {
            InitializeComponent();
            this.exName = exName;
        }

        

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("delete from Exercises where Exercises_Name='" + exName + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
