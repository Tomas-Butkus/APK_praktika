using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace APK_VL
{
    public class MarkRepository
    {
        private SqlConnection conn;

        public MarkRepository()
        {
            conn = new SqlConnection("Server =.; Database = AcademicSystem; Trusted_Connection = True;");
        }

        public double GetStudentMark(int studentId, int classId)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select mark from Mark where studentId=@studentId and classId=@classID", conn);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            cmd.Parameters.AddWithValue("@classId", classId);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            if (sqlDataReader.Read())
            {
                double mark = double.Parse(sqlDataReader["mark"].ToString());
                conn.Close();
                return mark;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        // Returns all of the marks
        public List<Mark> GetMarks()
        {
            List<Mark> markList = new List<Mark>();

            try
            {
                string sql = "select mark from Mark";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    double mark = double.Parse(sqlDataReader["mark"].ToString());
                    markList.Add(new Mark(mark));
                }

                conn.Close();
            }

            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            return markList;
        }

        // Change old student mark
        public void ChangeStudentMark(int studentId, int classId, double mark)
        {
            SqlCommand cmd = new SqlCommand("update Mark set mark=@mark where studentId=@studentId and classId=@classId", conn);

            cmd.Parameters.AddWithValue("@mark", mark);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            cmd.Parameters.AddWithValue("@classId", classId);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
