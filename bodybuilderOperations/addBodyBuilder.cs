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
    public partial class addBodyBuilder : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlDataReader dataReader;
        SqlCommand command;
        addEmployeeForm add;
        DateTime currentDate = DateTime.Now;
        public addBodyBuilder()
        {
            InitializeComponent();
            startDateTxt.Text = DateTime.Now.ToShortDateString();
            ExexpireDateTxt.Text = currentDate.AddMonths(1).ToShortDateString();

        }

        private void addBodyBuilder_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        char gender=' ';
        double payment = 0;
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (paymentCombo.Text)
            {
                case "1": paymentTxt.Text = "40$"; payment =40; break;
                case "3": paymentTxt.Text = "110$";payment = 110; break;
                case "6": paymentTxt.Text = "230$";payment = 230; break;
                case "12": paymentTxt.Text = "470$";payment = 470; break;
                default: break;
            }
            ExexpireDateTxt.Text = currentDate.AddMonths(int.Parse(paymentCombo.Text)).ToShortDateString();

        }                                     

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        
            if (firstnameTxt.Text !="" && lastnameTxt.Text !="" && weightTxt.Text !="" && heightTxt.Text !="" && illenessTxt.Text !="" && startDateTxt.Text!=""&&  ExexpireDateTxt.Text !="" && paymentTxt.Text!="" && maleOrfemale.Text!="" && phoneNumberTxt.Text!="") {
                connection.Close();
                connection.Open();
                if (maleOrfemale.Text == "Male")
                {
                    gender = 'M';
                }
                else
                {
                    gender = 'F';
                }
                command = new SqlCommand("insert into Body_Builder values('" + firstnameTxt.Text + "','" + lastnameTxt.Text + "','" + weightTxt.Text + "','" + heightTxt.Text + "'," +
                    "'" + illenessTxt.Text + "','" + startDateTxt.Text + "','" + ExexpireDateTxt.Text + "','" +payment + "','" + phoneNumberTxt.Text + "','" + gender + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
                
            }
            else
            {
                Emptyfields emptyfields = new Emptyfields();
                emptyfields.Show();
            }
        }
    }
}