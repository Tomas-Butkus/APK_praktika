using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace APK_VL
{
    public class ClassRepository
    {
        private SqlConnection conn;

        public ClassRepository()
        {
            conn = new SqlConnection("Server =.; Database = AcademicSystem; Trusted_Connection = True;");
        }

        // Add a class
        public void AddClass(string name, string description, double credits)
        {
            // Issue SQL command to a database (command, connection)
            SqlCommand cmd = new SqlCommand("INSERT INTO Class(name, description, credits)" +
                "values (@name, @description, @credits)", conn);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@credits", credits);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // Returns all of the classes
        public List<Class> GetClasses()
        {
            List<Class> classList = new List<Class>();

            try
            {
                string sql = "select name, description, credits from Class";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string name = sqlDataReader["name"].ToString();
                    string description = sqlDataReader["description"].ToString();
                    double credits = double.Parse(sqlDataReader["credits"].ToString());
                    classList.Add(new Class(name, description, credits));
                }

                conn.Close();
            }

            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            return classList;
        }

        //Get class ID by name
        public int GetClassId(string name)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select id from Class where name=@name", conn);
            cmd.Parameters.AddWithValue("@name", name);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            if (sqlDataReader.Read())
            {
                int id = int.Parse(sqlDataReader["id"].ToString());
                conn.Close();
                return id;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }
    }
}
