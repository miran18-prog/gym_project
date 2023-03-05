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
    public partial class addBils : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        DataTable dataTable2;
        public addBils()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        { 
            this.Dispose();
        }
        Emptyfields emptyfields;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            

            if (waterTxt.Text!=""&&electricityTxt.Text!=""&&gymTxt.Text!=""&&machineTxt.Text!=""&&bunifuDatepicker1.Value!=null)
            {
                connection.Close();
                connection.Open();
                command = new SqlCommand("insert into bills values('" + electricityTxt.Text + "'," + gymTxt.Text + "','" + waterTxt.Text + "','" + machineTxt.Text + "','" + DateTime.Now.ToShortDateString() + "')", connection);
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
