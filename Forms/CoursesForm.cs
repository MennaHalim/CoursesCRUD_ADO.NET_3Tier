using System.Configuration;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using UniversitySystem.BLL;
using UniversitySystem.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class CoursesForm : Form
    {
        CourseBLL courseBLL = new CourseBLL();
        DepartmentBLL departmentBLL = new DepartmentBLL();
        int selectedRowIndex = -1;
        public CoursesForm()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void LoadGrid()
        {
            var courses = courseBLL.GetAll();

            CoursesGridView.DataSource = courses;

            // Set up the "DepartmentName" column
            SetDepartmentNameColumn();
        }

        private void SetDepartmentNameColumn()
        {
            // Add "DepartmentName" column if it doesn't exist
            if (!CoursesGridView.Columns.Contains("DepartmentName"))
            {
                DataGridViewTextBoxColumn departmentNameColumn = new DataGridViewTextBoxColumn();
                departmentNameColumn.Name = "DepartmentName";
                departmentNameColumn.HeaderText = "Department Name";
                CoursesGridView.Columns.Add(departmentNameColumn);
            }
        }

        private void CoursesGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (CoursesGridView.Columns[e.ColumnIndex].Name == "DepartmentName")
            {
                CoursesGridView.Columns["departmentId"].Visible = false;
                int departmentId = (int)CoursesGridView.Rows[e.RowIndex].Cells["DepartmentId"].Value;
                e.Value = GetDepartmentName(departmentId);
            }
        }

        private string GetDepartmentName(int departmentId)
        {
            var department = departmentBLL.GetOne(departmentId);
            return department != null ? department.Name : "Unknown";
        }


        private void CoursesGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CoursesGridView.SelectedRows.Count > 0)
            {
                ShowButtons();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = CoursesGridView.SelectedRows[0];

            Course course = new Course()
            {
                Id = int.Parse(selectedRow.Cells["Id"].Value.ToString()),
                Name = selectedRow.Cells["Name"].Value.ToString(),
                Degree = int.Parse(selectedRow.Cells["Degree"].Value.ToString()),
                MinDegree = int.Parse(selectedRow.Cells["MinDegree"].Value.ToString()),
                DepartmentId = int.Parse(selectedRow.Cells["DepartmentId"].Value.ToString())
            };

            Hide();
            new Update_Form(course).ShowDialog();
            Show();
            HideButtons();
            LoadGrid();


            selectedRowIndex = -1;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Hide();
            new AddForm().ShowDialog();
            Show();
            LoadGrid();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = CoursesGridView.SelectedRows[0];
            selectedRowIndex = CoursesGridView.SelectedRows[0].Index;

            int id = int.Parse(selectedRow.Cells["Id"].Value.ToString());

            // Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                courseBLL.Delete(id);
                LoadGrid();
            }

            selectedRowIndex = -1;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            HideButtons();
        }

        private void ShowButtons()
        {
            UpdateButton.Show();
            DeleteButton.Show();
        }

        private void HideButtons()
        {
            UpdateButton.Hide();
            DeleteButton.Hide();
        }

    }
}
