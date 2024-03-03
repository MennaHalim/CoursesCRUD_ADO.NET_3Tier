using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.DAL
{
    public interface ICourseDAL
    {
        DataTable GetAll();
        DataRow? GetOne(int courseId);
        int Insert(string Name, int Degree, int MinDegree, int DeptId);
        int Update(int courseId, string Name, int Degree, int MinDegree, int DeptId);
        int Delete(int courseId);
    }
}
