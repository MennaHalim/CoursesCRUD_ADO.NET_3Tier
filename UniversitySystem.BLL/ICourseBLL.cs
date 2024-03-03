using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.BLL
{
    public interface ICourseBLL
    {
        List<Course> GetAll();
        Course? GetOne(int courseId);
        bool Update(int courseId, string name, int degree, int minDegree, int departmentId);
        bool Delete(int courseId);
        bool Insert(string Name, int Degree, int MinDegree, int DepartmentId);



    }
}
