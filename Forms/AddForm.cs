using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.BLL;
using UniversitySystem.DAL;

namespace Forms
{
    public partial class AddForm : Form
    {
        private readonly ICourseBLL CourseBLL;
        private readonly IDepartmentBLL DepartmentBLL;
        public AddForm(ICourseBLL courseBLL, IDepartmentBLL departmentBLL)
        {
            CourseBLL = courseBLL;
            DepartmentBLL = departmentBLL;
            InitializeComponent();
            LoadDepartments();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            int degree = int.Parse(DegreeTextBox.Text);
            int minDegree = int.Parse(MinimumDegreeTextBox.Text);
            int departmentId = int.Parse(DepartmentsComboBox.SelectedValue.ToString());

            CourseBLL.Insert(name, degree, minDegree, departmentId);

            Close();
        }
        private void LoadDepartments()
        {
            DepartmentsComboBox.DataSource = DepartmentBLL.GetAll();
            DepartmentsComboBox.DisplayMember = "Name";
            DepartmentsComboBox.ValueMember = "Id";
        }
    }
}
