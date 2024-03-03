using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.DAL
{
    public interface IDepartmentDAL
    {
        DataTable GetAll();
        DataRow? GetOne(int courseId);
    }
}
