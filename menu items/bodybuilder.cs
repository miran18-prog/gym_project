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
    public partial class bodybuilder : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        deleteBodyBuilderForm deleteBodyBuilder;
        editBodyBuilder editBodyBuilder;
        exersiceForm exersiceForm;
        public bodybuilder()
        {
            InitializeComponent();
            loadFromSql();
            this.bunifuCustomDataGrid2.MouseWheel += new MouseEventHandler(mousewheel);

        }
        void loadFromSql()
        {
            command = new SqlCommand("select * from Body_Builder", connection);
            dataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            bunifuCustomDataGrid2.DataSource = dataTable;
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
        private void check(DataGridView dataGridView1, ScrollEventArgs e)
        {
            if (e.NewValue >= 0 && e.NewValue < dataGridView1.Rows.Count)
            {
                // Update the position of the DataGridView control for vertical scrolling
                dataGridView1.FirstDisplayedScrollingRowIndex = e.NewValue;

            }
        }
        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2VScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            check(bunifuCustomDataGrid2, e);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addBodyBuilder add = new addBodyBuilder();
            add.ShowDialog();
        }

      
        private void bunifuCustomDataGrid2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == bunifuCustomDataGrid2.Columns["delete"].Index && e.RowIndex >= 0)
            {
                deleteBodyBuilder = new deleteBodyBuilderForm(bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[0].Value.ToString());
                deleteBodyBuilder.ShowDialog();
            }
            else if (e.ColumnIndex == bunifuCustomDataGrid2.Columns["edit"].Index && e.RowIndex >= 0)
            {
                editBodyBuilder = new editBodyBuilder(bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[0].Value.ToString());
                editBodyBuilder.ShowDialog();
            }
            else if (e.ColumnIndex == bunifuCustomDataGrid2.Columns["excersise"].Index && e.RowIndex >= 0)
            {
                exersiceForm = new exersiceForm(bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[0].Value.ToString());
                exersiceForm.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadFromSql();
        }

        void loadByFilter()
        {
            command = new SqlCommand("select * from Body_Builder order by '"+filterComobox.Text+"'", connection);
            dataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            bunifuCustomDataGrid2.DataSource = dataTable;
        }
        private void filterComobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadByFilter();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("select * from body_builder where bd_first_name like '"+searchTxt.Text+"%'",connection);
            dataAdapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            bunifuCustomDataGrid2.DataSource = dataTable;

            connection.Close();
        }

        private void bodybuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
