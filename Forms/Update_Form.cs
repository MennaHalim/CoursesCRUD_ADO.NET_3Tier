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
using UniversitySystem.BLL.DTOs;
using UniversitySystem.DAL;

namespace Forms
{
    public partial class Update_Form : Form
    {
        private readonly ICourseBLL CourseBLL;
        private readonly IDepartmentBLL DepartmentBLL;
        Course Course;
        public Update_Form(ICourseBLL courseBLL, IDepartmentBLL departmentBLL, Course course)
        {
            CourseBLL = courseBLL;
            DepartmentBLL = departmentBLL;
            Course = course;
            InitializeComponent();
            LoadDepartments();
            LoadCourseData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            int degree = int.Parse(DegreeTextBox.Text);
            int minDegree = int.Parse(MinimumDegreeTextBox.Text);
            int departmentId = int.Parse(DepartmentsComboBox.SelectedValue.ToString());

            CourseBLL.Update(Course.Id, name, degree, minDegree, departmentId);

            Close();
        }

        private void LoadCourseData()
        {
            NameTextBox.Text = Course.Name;
            DegreeTextBox.Text = Course.Degree.ToString();
            MinimumDegreeTextBox.Text = Course.MinDegree.ToString();
            DepartmentsComboBox.SelectedValue = Course.DepartmentId;
        }

        private void LoadDepartments()
        {
            DepartmentsComboBox.DataSource = DepartmentBLL.GetAll();
            DepartmentsComboBox.DisplayMember = "Name";
            DepartmentsComboBox.ValueMember = "Id";
        }
    }
}
