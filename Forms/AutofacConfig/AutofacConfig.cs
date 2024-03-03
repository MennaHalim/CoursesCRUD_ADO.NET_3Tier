using Autofac;
using System.Configuration;
using UniversitySystem.BLL;
using UniversitySystem.DAL;

namespace Forms.AutofacConfig
{
    public class AutofacConfig
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // Retrieve connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            // DAL
            builder.RegisterType<CourseDAL>().As<ICourseDAL>()
                   .WithParameter("connectionString", connectionString);
            builder.RegisterType<DepartmentDAL>().As<IDepartmentDAL>()
                   .WithParameter("connectionString", connectionString);

            // BLL
            builder.RegisterType<CourseBLL>().As<ICourseBLL>();
            builder.RegisterType<DepartmentBLL>().As<IDepartmentBLL>();

            // Forms
            builder.RegisterType<CoursesForm>().As<CoursesForm>();
            builder.RegisterType<AddForm>().As<AddForm>();
            builder.RegisterType<Update_Form>().As<Update_Form>();

            return builder.Build();
        }
    }
}
