using Guna.UI2.WinForms;
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
    public partial class mainDashboard : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        DataTable dataTable2;
        SqlDataReader dataReader;
        float oneMonth = 0;
        float threeMonth = 0;
        float sixMonth = 0;
        float year = 0;
        public mainDashboard()
        {
            InitializeComponent();
            this.bunifuCustomDataGrid2.ScrollBars = ScrollBars.None;
            this.bunifuCustomDataGrid2.MouseWheel += new MouseEventHandler(mousewheel);

            getMembershipTypes();
            label8.Text = oneMonth.ToString();
            label5.Text = threeMonth.ToString();
            label9.Text = sixMonth.ToString();
            label11.Text = year.ToString();



        }

        void getMembershipTypes()
        {
            connection.Close();
            var arr = new[] { 30, 90, 180, 365 };
            float counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                connection.Open();
                command = new SqlCommand("SELECT * FROM Body_Builder WHERE DATEDIFF(day , BD_Start_Date , BD_Expire_Date)  = '" + arr[i] + "'", connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (arr[i] == 30) oneMonth++;
                    else if (arr[i] == 90) threeMonth++;
                    else if (arr[i] == 180) sixMonth++;
                    else if (arr[i] == 365) year++;
                    counter++;
                }
                connection.Close();
            }
            guna2CircleProgressBar3.Value = Convert.ToInt32(oneMonth / counter * 100);

        }

        void selectActives()
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("SELECT *  FROM Body_Builder WHERE BD_Expire_Date >= GETDATE()  AND BD_Start_Date <= GETDATE()", connection);
            dataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            command.ExecuteNonQuery();
            connection.Close();
            activeLabel.Text = dataTable.Rows.Count.ToString();
        }

        void selectIlls()
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("SELECT *FROM Body_Builder WHERE BD_Illeness <> 'none' ", connection);
            dataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            command.ExecuteNonQuery();
            illLabel.Text = dataTable.Rows.Count.ToString();
            connection.Close();
        }

        void selectExpires()
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("SELECT * FROM Body_Builder WHERE BD_expire_date < GETDATE()", connection);
            dataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            command.ExecuteNonQuery();
            connection.Close();
            expiredLabel.Text = dataTable.Rows.Count.ToString();
        }

        // awanay ka 5 rozhyan maya lo expirebun
        void loadFromSql()
        {
            connection.Close();
            connection.Open();
           
            command = new SqlCommand("SELECT * FROM Body_Builder WHERE BD_expire_date < GETDATE()", connection);
            dataAdapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            bunifuCustomDataGrid2.DataSource = dataTable;
            connection.Close();
        }
        private void check(DataGridView dataGridView1, ScrollEventArgs e)
        {
            if (e.NewValue >= 0 && e.NewValue < dataGridView1.Rows.Count)
            {
                // Update the position of the DataGridView control for vertical scrolling
                dataGridView1.FirstDisplayedScrollingRowIndex = e.NewValue;
            }
        }
                   
        void imageLoader()
        {
        }
        private void sliderTimer_Tick(object sender, EventArgs e)
        {
            imageLoader();
        }

        private void mainDashboard_Load(object sender, EventArgs e)
        {
            selectActives();
            selectIlls();
            selectExpires();
            loadFromSql();
        }

        private void guna2VScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            check(bunifuCustomDataGrid2, e);
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomDataGrid2_Scroll(object sender, ScrollEventArgs e)
        {
            check(bunifuCustomDataGrid2, e);
        }

        private void bunifuCustomDataGrid2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void mousewheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta > 0 && bunifuCustomDataGrid2.FirstDisplayedScrollingRowIndex > 0)
                {
                    bunifuCustomDataGrid2.FirstDisplayedScrollingRowIndex--;
                }
                else if (e.Delta < 0)
                {
                    bunifuCustomDataGrid2.FirstDisplayedScrollingRowIndex++;
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {

            }
          

        }

        private void guna2ShadowPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    

