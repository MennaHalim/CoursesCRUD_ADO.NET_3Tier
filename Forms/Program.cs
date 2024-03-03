using System.Configuration;
using Autofac;
using System.Windows.Forms;

namespace Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Build Autofac container
            var container = AutofacConfig.AutofacConfig.BuildContainer();

            // Resolve and run the main form
            using (var scope = container.BeginLifetimeScope())
            {
                var mainForm = scope.Resolve<CoursesForm>();
                Application.Run(mainForm);
            }
        }
    }
}
