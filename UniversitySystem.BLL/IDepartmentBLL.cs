using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.BLL.DTOs;

namespace UniversitySystem.BLL
{
    public interface IDepartmentBLL
    {
        List<Department> GetAll();
        Department? GetOne(int departmentId);
    }
}
