using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace APK_VL
{
    public class StudentGroupRepository
    {
        private SqlConnection conn;

        public StudentGroupRepository()
        {
            // SQL server connection
            conn = new SqlConnection("Server =.; Database = AcademicSystem; Trusted_Connection = True;");
        }

        // Check the group classes of the current student
        public bool CheckStudentGroupClasses(int studentId, int classId)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from StudentGroup where studentId=@studentId and classId=@classId", conn);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            cmd.Parameters.AddWithValue("@classId", classId);

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
    }
}
