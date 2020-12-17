using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace APK_VL
{
    public class AdminRepository
    {
        private SqlConnection conn;

        public AdminRepository()
        {
            // SQL server connection
            conn = new SqlConnection("Server =.; Database = AcademicSystem; Trusted_Connection = True;");
        }

        // Check for login credentials
        public bool CheckLoginCredentials(string username, string password)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Administrator where username=@username and password=@password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                conn.Close();
                return true;
            }

            else
            {
                conn.Close();
                return false;
            }
        }

        // Get logged in user ID
        public int GetUserId(string username, string password)
        {
            // Issue SQL command to a database (command, connection)
            int id;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select id from Administrator where username=@username and password=@password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            if (sqlDataReader.Read())
            {
                id = int.Parse(sqlDataReader["id"].ToString());
                return id;
            }

            else return 0;
        }
    }
}