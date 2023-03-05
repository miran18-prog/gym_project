using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace gym_management_system
{

        
    class sqlQueries
    {

        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=gym_managemnt;Integrated Security=True");
        SqlDataReader dataReader;
        SqlCommand command;
        
        public SqlDataReader getCurrentUser(int userId)
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand("select Emp_username from Employee where Emp_id ='"+userId+"'",connection);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                // dataReader["Emp_username"].ToString();
                return dataReader;
            }
            else return null;
        }

        
    }
}
