﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.DAL
{
    public class DepartmentDAL :IDepartmentDAL
    {
        private readonly string connectionString;

        public DepartmentDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public DataTable GetAll()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Departments", new SqlConnection(connectionString));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataRow? GetOne(int departmentId)
        {
            SqlDataAdapter sqlDataAdapter;
            DataTable dataTable = new DataTable();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Departments WHERE Dept_Id = @DepartmentId", new SqlConnection(connectionString));
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DepartmentId", departmentId);
            sqlDataAdapter.Fill(dataTable);

            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }

    }
}
