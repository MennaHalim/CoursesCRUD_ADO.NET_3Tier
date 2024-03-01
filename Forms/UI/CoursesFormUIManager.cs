using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.BLL;
using UniversitySystem.DAL;

namespace Forms.UI
{
    // CoursesFormUIManager class
    public class CoursesFormUIManager
    {
        private readonly DataGridView coursesGridView;
        private readonly Button updateButton;
        private readonly Button deleteButton;
        DepartmentBLL departmentBLL;

        public CoursesFormUIManager(DataGridView coursesGridView, Button updateButton, Button deleteButton ,DepartmentBLL departmentBLL)
        {
            this.coursesGridView = coursesGridView;
            this.updateButton = updateButton;
            this.deleteButton = deleteButton;
            this.departmentBLL = departmentBLL;
        }

        public void Initialize()
        {
            coursesGridView.AutoGenerateColumns = false;
            coursesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            coursesGridView.MultiSelect = false;

            coursesGridView.CellFormatting += CoursesGridView_CellFormatting;
            coursesGridView.SelectionChanged += CoursesGridView_SelectionChanged;
        }

        public void LoadCourses(List<Course> courses)
        {
            coursesGridView.DataSource = courses;
            SetDepartmentNameColumn();
        }

        private void SetDepartmentNameColumn()
        {
            if (!coursesGridView.Columns.Contains("DepartmentName"))
            {
                DataGridViewTextBoxColumn departmentNameColumn = new DataGridViewTextBoxColumn();
                departmentNameColumn.Name = "DepartmentName";
                departmentNameColumn.HeaderText = "Department Name";
                coursesGridView.Columns.Add(departmentNameColumn);
            }
        }

        private void CoursesGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = coursesGridView.Rows[e.RowIndex];
                DataGridViewColumn column = coursesGridView.Columns[e.ColumnIndex];

                if (column.Name == "DepartmentName")
                {
                    int departmentId = (int)row.Cells["DepartmentId"].Value;
                    e.Value = GetDepartmentName(departmentId);
                }
            }
        }

        private string GetDepartmentName(int departmentId)
        {
            var department = departmentBLL.GetOne(departmentId);
            return department != null ? department.Name : "Unknown";
        }

        private void CoursesGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (coursesGridView.SelectedRows.Count > 0)
            {
                ShowButtons();
            }
            else
            {
                HideButtons();
            }
        }

        public void ShowButtons()
        {
            updateButton.Show();
            deleteButton.Show();
        }

        public void HideButtons()
        {
            updateButton.Hide();
            deleteButton.Hide();
        }
    }

}
