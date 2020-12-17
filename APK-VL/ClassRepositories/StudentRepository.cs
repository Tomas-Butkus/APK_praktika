using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace APK_VL
{
    public class StudentRepository
    {
        private SqlConnection conn;

        public StudentRepository()
        {
            // SQL server connection
            conn = new SqlConnection("Server =.; Database = AcademicSystem; Trusted_Connection = True;");
        }

        // Returns student list
        public List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>();

            try
            {
                string sql = "select firstName, lastName from Student";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string firstName = sqlDataReader["firstName"].ToString();
                    string lastName = sqlDataReader["lastName"].ToString();
                    studentList.Add(new Student(firstName, lastName, "-", "-"));
                }

                conn.Close();
            }

            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            return studentList;
        }

        // Check for login credentials
        public bool CheckLoginCredentials(string username, string password)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Student where username=@username and password=@password", conn);
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
            int id;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select id from Student where username=@username and password=@password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            if (sqlDataReader.Read())
            {
                id = int.Parse(sqlDataReader["id"].ToString());
                conn.Close();
                return id;
            }

            else
            {
                conn.Close();
                return 0;
            }
        }

        // Get logged in user full name
        public string GetUserFullName(int id)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select firstName, lastName from Student where id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            if (sqlDataReader.Read())
            {
                string firstName = sqlDataReader["firstName"].ToString();
                string lastName = sqlDataReader["lastName"].ToString();
                string fullName = firstName + " " + lastName;

                conn.Close();
                return fullName;
            }
            else
            {
                conn.Close();
                return null;
            }
        }

        //Get student ID by first and last name
        public int GetStudentId(string firstName, string lastName)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select id from Student where firstName=@firstName and lastName=@lastName", conn);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);

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