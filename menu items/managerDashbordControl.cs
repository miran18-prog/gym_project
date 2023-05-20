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
using System.Windows.Forms.DataVisualization.Charting;

namespace gym_management_system
{
    public partial class managerDashbordControl : UserControl
    {

        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        List<Color> colors = new List<Color> { Color.FromArgb(79, 206, 162), Color.FromArgb(40, 104, 82), Color.FromArgb(55, 143, 113), Color.FromArgb(25, 66, 52) };
        int x = 10;
        string totalSalaries = "";
        string totalEx = "";
        string totalMembership = "";
        addBils addBils;
        public managerDashbordControl()
        {
            InitializeComponent();

          

            trainersCounter.Text = countEmployees("Trainer").ToString() ;
            janitorCounter.Text = countEmployees("Janitorial staff").ToString();
            frontDeskCounter.Text = countEmployees(" Front desk staff").ToString();
            totalTrainer.Text = getTotalSalary("Trainer").ToString() + '$';
            totalJanitor.Text = getTotalSalary("Janitorial staff").ToString() + '$';
            totalFrontDesk.Text = getTotalSalary(" Front desk staff").ToString() + '$';
            totalSalaries = (getTotalSalary("Janitorial staff") + getTotalSalary("Trainer") + getTotalSalary(" Front desk staff")).ToString();
            totalSalary.Text = (getTotalSalary("Janitorial staff") + getTotalSalary("Trainer") + getTotalSalary(" Front desk staff")).ToString() +'$';
            getExpens();
            memberShipIncome();


            var t = getTotalSalary("Trainer") /*/ float.Parse(totalEx) * 100*/;
            var t2 = getTotalSalary("Janitorial staff") /*/ float.Parse(totalEx) * 100*/;
            var t3 = getTotalSalary(" Front desk staff") /*/ float.Parse(totalEx) * 100*/;
            var sum = t + t2 + t3;

            trainerProgress.Value =Convert.ToInt32( getTotalSalary("Trainer") / sum * 100);
            janitorProgress.Value = Convert.ToInt32(getTotalSalary("Janitorial staff") / sum * 100);
            frontDeskProgress.Value = Convert.ToInt32(getTotalSalary(" Front desk staff") / sum * 100);


            var data = new[] { int.Parse(totalSalaries), int.Parse(totalEx), int.Parse(totalMembership), int.Parse(totalMembership) };

            // Define labels
            var labels = new[] { "Total Employee salary", "Total Expenses", "Total Paid Memberships", "Profit" };

            // Add data to series
            for (int i = 0; i < data.Length; i++)
            {
                chart1.Series["Series1"].Points.AddXY("", data[i]);
                chart1.Series[0].Points[i].LegendText = labels[i];
                chart1.Series[0].Points[i].Color = colors[i];
                chart1.Series[0].Points[i].LabelForeColor = Color.WhiteSmoke;
            }
            chart1.Legends[0].Font = new Font("open sans", 11);
            chart1.Series["Series1"].MarkerBorderWidth = 2;


            label31.Text = (sum + Convert.ToInt32(totalEx) - memberShipIncome()).ToString() + "$";
        }

        int countEmployees(string role)
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("select * from employee where emp_role ='"+role+"'",connection);
            dataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            command.ExecuteNonQuery();
            connection.Close();
            return dataTable.Rows.Count;
        }

        float getTotalSalary(string role)
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("SELECT SUM(emp_salary) AS salary FROM employee where emp_role ='" + role + "'", connection);
            dataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            command.ExecuteNonQuery();
            connection.Close();
            return float.Parse(dataTable.Rows[0][0].ToString());
        }
        float getExpens()
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("select * from bills", connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                eBill.Text = dataReader["electricity"].ToString() + '$';
                waterBill.Text = dataReader["water_bill"].ToString() + '$';
                machineBill.Text = dataReader["machine_expenses"].ToString() + '$';
                gymLabel.Text = dataReader["gym_rent"].ToString() + '$';
                totalEx = (float.Parse(dataReader["electricity"].ToString()) + float.Parse(dataReader["water_bill"].ToString()) +
                    float.Parse(dataReader["machine_expenses"].ToString()) + float.Parse(dataReader["gym_rent"].ToString())).ToString();
                totalExpenses.Text = totalEx + '$';
            }
            connection.Close();
            return float.Parse(totalEx);
        }
      
        float memberShipIncome()
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("select SUM(BD_Membership_Payment) from body_builder", connection);
            dataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            command.ExecuteNonQuery();
            connection.Close();
            membershipIncome.Text = dataTable.Rows[0][0].ToString() +'$';
            totalMembership = dataTable.Rows[0][0].ToString();
            return float.Parse(totalMembership);
        }
        
    
        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void managerDashbordControl_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addBils = new addBils();
            addBils.Show();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalFrontDesk_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
