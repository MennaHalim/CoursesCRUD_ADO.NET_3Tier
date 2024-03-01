using UniversitySystem.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.BLL
{
    public class CourseBLL
    {
        CourseDAL CourseDAL = new CourseDAL();

        public List<Course> GetAll()
        {
            List<Course> list = new List<Course>();

            DataTable dataTable = CourseDAL.GetAll();
            foreach (DataRow item in dataTable.Rows)
            {
                Course course = new Course();
                course.Id = (int)item["Crs_Id"];
                course.Name = item["Crs_Name"].ToString();
                course.Degree = (int)item["Degree"];
                course.MinDegree = (int)item["MinDegree"];
                course.DepartmentId = (int)item["dept_id"];

                list.Add(course);
            }

            return list;
        }

        public Course? GetOne(int courseId)
        {
            DataRow? row = CourseDAL.GetOne(courseId);
            if (row != null)
            {
                Course course = new Course();
                course.Id = (int)row["Crs_Id"];
                course.Name = row["Crs_Name"].ToString();
                course.Degree = (int)row["Degree"];
                course.MinDegree = (int)row["MinDegree"];
                course.DepartmentId = (int)row["dept_id"];
                return course;
            }
            return null;
        }

        public bool Update(int courseId, string name, int degree, int minDegree, int departmentId)
        {
            int result = CourseDAL.Update(courseId, name, degree, minDegree, departmentId);
            return result > 0;
        }

        public bool Delete(int courseId)
        {
            int result = CourseDAL.Delete(courseId);
            return result > 0;
        }

        public bool Insert(string Name, int Degree, int MinDegree, int DepartmentId)
        {
            int result = CourseDAL.Insert(Name, Degree, MinDegree, DepartmentId);
            return result > 0;
        }
    }

}
