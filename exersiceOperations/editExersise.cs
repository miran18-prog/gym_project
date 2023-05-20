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
    public partial class editExersise : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        public editExersise(string eName)
        {
            InitializeComponent();
            exerciseNameTxt.Text = eName;

            connection.Close();
            connection.Open();
            command = new SqlCommand("select * from Exercises where exercises_name ='"+exerciseNameTxt.Text+"'", connection);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                setsTxt.Text = dataReader["Exercises_Sets"].ToString();
                repsTxt.Text = dataReader["Exercises_Reps"].ToString();
                exerciseNameTxt.Text = dataReader["Exercises_Name"].ToString();
            }
            connection.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editExersise_Load(object sender, EventArgs e)
        {

        }
        Emptyfields emptyfields;
        private void guna2Button3_Click(object sender, EventArgs e)
        {

            if (setsTxt.Text!=""&& repsTxt.Text!=""&&exerciseNameTxt.Text!="") {
                connection.Close();
                connection.Open();
                command = new SqlCommand("update Exercises set  Exercises_Name='" + exerciseNameTxt.Text + "', Exercises_Sets='" + setsTxt.Text + "'," +
                    "Exercises_Reps ='" + repsTxt.Text + "' where Exercises_name='" + exerciseNameTxt.Text + "' ", connection);
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

        private void exerciseNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
