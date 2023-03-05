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
    public partial class exersiceForm : Form
    {
        string bodybuilderId;
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        public exersiceForm(string i)
        {
            InitializeComponent();
            bodybuilderId = i;


            connection.Close();
            connection.Open();
            command = new SqlCommand("select emp_username from Employee where Emp_Role = 'Trainer'",connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                trainerCombo.Items.Add(dataReader["emp_username"].ToString() + Environment.NewLine);
            }
            connection.Close();


            this.bunifuCustomDataGrid2.MouseWheel += new MouseEventHandler(mousewheel);
            loadExersices();


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
            }catch (System.ArgumentOutOfRangeException ex)
            {

            }
        }
        void loadExersices()
        {
            command = new SqlCommand("select * from Exercises where Exercises_Id = '"+ bodybuilderId + "'", connection);
            dataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            bunifuCustomDataGrid2.DataSource = dataTable;
        }
        
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void check(DataGridView dataGridView1, ScrollEventArgs e)
        {
            if (e.NewValue >= 0 && e.NewValue < dataGridView1.Rows.Count)
            {
                // Update the position of the DataGridView control for vertical scrolling
                dataGridView1.FirstDisplayedScrollingRowIndex = e.NewValue;

            }
        }
        private void guna2VScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            check(bunifuCustomDataGrid2, e);
        }

        private void exersiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gym_managemntDataSet4.exercises' table. You can move, or remove it, as needed.
            this.exercisesTableAdapter1.Fill(this.gym_managemntDataSet4.exercises);

            // TODO: This line of code loads data into the 'gym_managemntDataSet2.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.gym_managemntDataSet2.Employee);

        }
        CustomMessageBox messageBox;
        editExersise editEx ;
        deleteExersice deleteEx;
        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == bunifuCustomDataGrid2.Columns["delete"].Index && e.RowIndex >= 0)
            {
                deleteEx = new deleteExersice(bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[1].Value.ToString());
                deleteEx.Show();
            }
            else if (e.ColumnIndex == bunifuCustomDataGrid2.Columns["edit"].Index && e.RowIndex >= 0)
            {
                editEx = new editExersise(bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[1].Value.ToString());
                editEx.Show();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.FillBy(this.gym_managemntDataSet2.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadExersices();
        }
        Emptyfields emptyfields;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (setsTxt.Text != "" && reosTxt.Text != "" && setsTxt.Text!= ""&&trainerCombo.Text!="")
            {
                connection.Close();
                connection.Open();
                command = new SqlCommand("insert into Exercises values('" + bodybuilderId + "','" + exerciseTxt.Text + "' , '" + setsTxt.Text + "','" + reosTxt.Text + "','" + trainerCombo.Text + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();

                exerciseTxt.Clear();
                setsTxt.Clear();
                reosTxt.Clear();
            }
            else
            {
                emptyfields = new Emptyfields();
                emptyfields.ShowDialog();
            }
        }
    }
}
