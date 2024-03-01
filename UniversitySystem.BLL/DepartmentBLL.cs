using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.BLL.DTOs;
using UniversitySystem.DAL;

namespace UniversitySystem.BLL
{
    public class DepartmentBLL
    {
        DepartmentDAL departmentDAL = new DepartmentDAL();

        public List<Department> GetAll()
        {
            List<Department> list = new List<Department>();

            DataTable dataTable = departmentDAL.GetAll();
            foreach (DataRow item in dataTable.Rows)
            {
                Department department = new Department();
                department.Id = (int)item["Dept_Id"];
                department.Name = item["Name"].ToString();
                department.Manager = item["Manager"].ToString();

                list.Add(department);
            }

            return list;
        }

        public Department? GetOne(int departmentId)
        {
            DataRow? row = departmentDAL.GetOne(departmentId);
            if (row != null)
            {
                Department department = new Department();
                department.Id = (int)row["Dept_Id"];
                department.Name = row["Name"].ToString();
                department.Manager = row["Manager"].ToString();
                return department;
            }
            return null;
        }
    }
}
