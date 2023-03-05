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
    public partial class editBodyBuilder : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        string id;
        public editBodyBuilder(string i)
        {
            InitializeComponent();
            this.id = i;
            idTxt.Text = i;

            connection.Close();
            connection.Open();
            command = new SqlCommand("select * from Body_Builder where BD_ID ='" + id + "'", connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                firstnameTxt.Text = reader["BD_First_Name"].ToString();
                lastnameTxt.Text = reader["BD_Last_Name"].ToString();
                weightTxt.Text = reader["BD_Weight"].ToString();
                heightTxt.Text = reader["BD_Height"].ToString();
                illenessTxt.Text = reader["BD_Illeness"].ToString();
                phonenumberTxt.Text = reader["BD_Phone_Number"].ToString();

            }
            connection.Close();

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

        }

        private void editBodyBuilder_Load(object sender, EventArgs e)
        {

        }
        Emptyfields Emptyfields;
        private void guna2Button1_Click(object sender, EventArgs e)
        {


            if (firstnameTxt.Text != "" && lastnameTxt.Text != "" && illenessTxt.Text != "" && heightTxt.Text != "" && weightTxt.Text != "" && phonenumberTxt.Text != "")
            {
                connection.Close();
                connection.Open();
                command = new SqlCommand("Update Body_Builder set BD_First_Name='" + firstnameTxt.Text + "', BD_Last_Name='" + lastnameTxt.Text + "', BD_Weight='" + weightTxt.Text + "' ,BD_Height='" + heightTxt.Text + "', BD_Illeness='" + illenessTxt.Text + "'  where BD_ID='" + id + "'", connection);
                command.ExecuteReader();
                connection.Close();
            }
            else
            {
                Emptyfields = new Emptyfields();
                Emptyfields.ShowDialog();
            }
            this.Close();
        }
    }
}
