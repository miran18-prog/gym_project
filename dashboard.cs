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
    public partial class dashboard : Form
    {
        mainDashboard mainDashboard;
        employeeControl employee;
        bodybuilder bodybuilder;
        managerDashbordControl managerDashbordControl;
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlDataReader dataReader;
        SqlCommand command;
        CustomMessageBox customMessageBox;
        int currentUserId;
        accessError access;
        Color panelActiveColor = Color.FromArgb(60, 60, 60);
        Color panelDisabledColor = Color.FromArgb(33, 33, 33);
        Color acticeForeColor = Color.FromArgb(50, 130, 103);
        Color disabledForeColor = Color.Gray;
        LoginForm login;
        sqlQueries sqlQueries;

        public dashboard(int currentUserId)
        {
            this.currentUserId = currentUserId;
            InitializeComponent();
            mainDashboard = new mainDashboard();
            sqlQueries = new sqlQueries();
            usernameLabel.Text = sqlQueries.getCurrentUser(currentUserId)["Emp_username"].ToString();
            addUserConrol(mainDashboard, DockStyle.Fill);
            connection.Close();
        }


        
        private void minimseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximiseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            currentTimeTimer.Start();

        }

        private void currentTimeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void addUserConrol(UserControl userControl, DockStyle dockStyle)
        {
            userControl.Dock = dockStyle;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        void tab1()
        {
            homeIcon.Image = Properties.Resources.home_svgrepo_com__1_;
            employeeIcon.Image = Properties.Resources.workers_team_svgrepo_com;
            bodyBuilderIcon.Image = Properties.Resources.male_gymnast_flexing_arms;
            managerIcon.Image = Properties.Resources.manager;

            Tab1.BackColor = panelActiveColor;
            Tab2.BackColor = panelDisabledColor;
            bbTab.BackColor = panelDisabledColor;
            Tab4.BackColor = panelDisabledColor;

            dashbordLabel.ForeColor = acticeForeColor;
            employeeTabel.ForeColor = disabledForeColor;
            bodybuilderLabel.ForeColor = disabledForeColor;
            managerLabel.ForeColor = disabledForeColor;

            mainDashboard = new mainDashboard();
            addUserConrol(mainDashboard, DockStyle.Fill);
        }


        void tab2()
        {
            if (checkUserRole(currentUserId))
            {
                homeIcon.Image = Properties.Resources.home_svgrepo_com__2_;
                employeeIcon.Image = Properties.Resources.workers_team_svgrepo_com__1_;
                bodyBuilderIcon.Image = Properties.Resources.male_gymnast_flexing_arms;
                managerIcon.Image = Properties.Resources.manager;

                Tab2.BackColor = panelActiveColor;
                Tab1.BackColor = panelDisabledColor;
                bbTab.BackColor = panelDisabledColor;
                Tab4.BackColor = panelDisabledColor;

                employeeTabel.ForeColor = acticeForeColor;
                dashbordLabel.ForeColor = disabledForeColor;
                bodybuilderLabel.ForeColor = disabledForeColor;
                managerLabel.ForeColor = disabledForeColor;

                employee = new employeeControl();
                addUserConrol(employee, DockStyle.Fill);
            }
            else
            {
                access = new accessError();
                access.Show();
            }
        }

        void tab3()
        {
            homeIcon.Image = Properties.Resources.home_svgrepo_com__2_;
            employeeIcon.Image = Properties.Resources.workers_team_svgrepo_com;
            bodyBuilderIcon.Image = Properties.Resources.male_gymnast_flexing_arms__1_;
            managerIcon.Image = Properties.Resources.manager;

            Tab2.BackColor = panelDisabledColor;
            Tab1.BackColor = panelDisabledColor;
            bbTab.BackColor = panelActiveColor;
            Tab4.BackColor = panelDisabledColor;

            bodybuilderLabel.ForeColor = acticeForeColor;
            employeeTabel.ForeColor = disabledForeColor;
            dashbordLabel.ForeColor = disabledForeColor;
            managerLabel.ForeColor = disabledForeColor;

            bodybuilder = new bodybuilder();
            addUserConrol(bodybuilder, DockStyle.Fill);
        }
        void tab4()
        {

            if (checkUserRole(currentUserId))
            {
                homeIcon.Image = Properties.Resources.home_svgrepo_com__2_;
                employeeIcon.Image = Properties.Resources.workers_team_svgrepo_com;
                bodyBuilderIcon.Image = Properties.Resources.male_gymnast_flexing_arms;
                managerIcon.Image = Properties.Resources.manager__1_;

                Tab2.BackColor = panelDisabledColor;
                Tab1.BackColor = panelDisabledColor;
                bbTab.BackColor = panelDisabledColor;
                Tab4.BackColor = panelActiveColor;

                bodybuilderLabel.ForeColor = disabledForeColor;
                employeeTabel.ForeColor = disabledForeColor;
                dashbordLabel.ForeColor = disabledForeColor;
                managerLabel.ForeColor = acticeForeColor;

                managerDashbordControl = new managerDashbordControl();
                addUserConrol(managerDashbordControl, DockStyle.Fill);
            }
            else
            {
                access = new accessError();
                access.Show();
            }
        }

        void tab5()
        {
            login = new LoginForm();
            login.Show();
            this.Close();
        }

        bool checkUserRole(int userId)
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("select isAdmin from Employee where Emp_id= '" + userId + "' and isAdmin='" + 1 + "'", connection);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        private void Tab1_Click(object sender, EventArgs e) => tab1();

        private void guna2PictureBox3_Click(object sender, EventArgs e) => tab1();

        private void bunifuCustomLabel1_Click(object sender, EventArgs e) => tab1();

        private void Tab2_Click(object sender, EventArgs e) => tab2();
        private void guna2PictureBox4_Click(object sender, EventArgs e) => tab2();

        private void bunifuCustomLabel2_Click(object sender, EventArgs e) => tab2();

        private void bodybuilderLabel_Click(object sender, EventArgs e) => tab3();

        private void bodyBuilderIcon_Click(object sender, EventArgs e) => tab3();

        private void guna2Panel1_Click(object sender, EventArgs e) => tab3();

        private void Tab4_Click(object sender, EventArgs e) => tab4();

        private void managerLabel_Click(object sender, EventArgs e) => tab4();

        private void managerIcon_Click(object sender, EventArgs e) => tab4();

        private void Tab4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click_1(object sender, EventArgs e) => tab5();

        private void guna2PictureBox4_Click_1(object sender, EventArgs e) => tab5();

        private void Tab1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
