using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace UniversitySystem.DAL
{
    public class CourseDAL : ICourseDAL
    {
        private SqlCommand sqlCommand = new SqlCommand();
        private readonly string connectionString;

        public CourseDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DataTable GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Courses", new SqlConnection(connectionString));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }


        public DataRow? GetOne(int courseId)
        {
            SqlDataAdapter sqlDataAdapter;
            DataTable dataTable = new DataTable();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Courses WHERE CourseId = @CourseId", new SqlConnection(connectionString));
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@CourseId", courseId);
            sqlDataAdapter.Fill(dataTable);

            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }



        public int Insert(string Name, int Degree, int MinDegree, int DeptId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlCommand.CommandText = "INSERT INTO Courses VALUES (@Name, @Degree , @MinDegree, @DeptId)";
                sqlCommand.Connection = sqlConnection;

                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@Degree", Degree);
                sqlCommand.Parameters.AddWithValue("@MinDegree", MinDegree);
                sqlCommand.Parameters.AddWithValue("@DeptId", DeptId);

                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();

            }
        }


        public int Update(int courseId, string Name, int Degree, int MinDegree, int DeptId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlCommand.CommandText = "UPDATE Courses SET Crs_Name = @Name, Degree = @Degree, MinDegree = @MinDegree, dept_id = @DeptId WHERE Crs_Id = @CourseId";
                sqlCommand.Connection = sqlConnection;

                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@CourseId", courseId);
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@Degree", Degree);
                sqlCommand.Parameters.AddWithValue("@MinDegree", MinDegree);
                sqlCommand.Parameters.AddWithValue("@DeptId", DeptId);

                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();

            }
        }

        public int Delete(int courseId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlCommand.CommandText = "DELETE FROM Courses WHERE Crs_Id = @CourseId";
                sqlCommand.Connection = sqlConnection;

                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@CourseId", courseId);

                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();

            }
        }
    }
}
