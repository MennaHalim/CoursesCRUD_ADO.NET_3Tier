namespace Forms
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DepartmentsComboBox = new ComboBox();
            DegreeTextBox = new TextBox();
            MinimumDegreeTextBox = new TextBox();
            NameTextBox = new TextBox();
            DepartmentIdLabel = new Label();
            MinimumDegreeLabel = new Label();
            DegreeLabel = new Label();
            CourseNamelabel = new Label();
            AddButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // DepartmentsComboBox
            // 
            DepartmentsComboBox.FormattingEnabled = true;
            DepartmentsComboBox.Location = new Point(299, 318);
            DepartmentsComboBox.Name = "DepartmentsComboBox";
            DepartmentsComboBox.Size = new Size(280, 28);
            DepartmentsComboBox.TabIndex = 16;
            // 
            // DegreeTextBox
            // 
            DegreeTextBox.Location = new Point(299, 207);
            DegreeTextBox.Name = "DegreeTextBox";
            DegreeTextBox.Size = new Size(281, 27);
            DegreeTextBox.TabIndex = 15;
            // 
            // MinimumDegreeTextBox
            // 
            MinimumDegreeTextBox.Location = new Point(299, 261);
            MinimumDegreeTextBox.Name = "MinimumDegreeTextBox";
            MinimumDegreeTextBox.Size = new Size(280, 27);
            MinimumDegreeTextBox.TabIndex = 14;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(300, 152);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(281, 27);
            NameTextBox.TabIndex = 13;
            // 
            // DepartmentIdLabel
            // 
            DepartmentIdLabel.AutoSize = true;
            DepartmentIdLabel.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepartmentIdLabel.Location = new Point(126, 318);
            DepartmentIdLabel.Name = "DepartmentIdLabel";
            DepartmentIdLabel.Size = new Size(101, 19);
            DepartmentIdLabel.TabIndex = 12;
            DepartmentIdLabel.Text = "Department :";
            // 
            // MinimumDegreeLabel
            // 
            MinimumDegreeLabel.AutoSize = true;
            MinimumDegreeLabel.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinimumDegreeLabel.Location = new Point(126, 261);
            MinimumDegreeLabel.Name = "MinimumDegreeLabel";
            MinimumDegreeLabel.Size = new Size(141, 19);
            MinimumDegreeLabel.TabIndex = 11;
            MinimumDegreeLabel.Text = "Minimum Degree :";
            // 
            // DegreeLabel
            // 
            DegreeLabel.AutoSize = true;
            DegreeLabel.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DegreeLabel.Location = new Point(126, 207);
            DegreeLabel.Name = "DegreeLabel";
            DegreeLabel.Size = new Size(68, 19);
            DegreeLabel.TabIndex = 10;
            DegreeLabel.Text = "Degree :";
            // 
            // CourseNamelabel
            // 
            CourseNamelabel.AutoSize = true;
            CourseNamelabel.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseNamelabel.Location = new Point(126, 152);
            CourseNamelabel.Name = "CourseNamelabel";
            CourseNamelabel.Size = new Size(116, 19);
            CourseNamelabel.TabIndex = 9;
            CourseNamelabel.Text = "Course Name : ";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(300, 399);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(281, 29);
            AddButton.TabIndex = 17;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 46);
            label1.Name = "label1";
            label1.Size = new Size(235, 47);
            label1.TabIndex = 18;
            label1.Text = "Add Course";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Controls.Add(DepartmentsComboBox);
            Controls.Add(DegreeTextBox);
            Controls.Add(MinimumDegreeTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(DepartmentIdLabel);
            Controls.Add(MinimumDegreeLabel);
            Controls.Add(DegreeLabel);
            Controls.Add(CourseNamelabel);
            Name = "AddForm";
            Text = "Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DepartmentsComboBox;
        private TextBox DegreeTextBox;
        private TextBox MinimumDegreeTextBox;
        private TextBox NameTextBox;
        private Label DepartmentIdLabel;
        private Label MinimumDegreeLabel;
        private Label DegreeLabel;
        private Label CourseNamelabel;
        private Button AddButton;
        private Label label1;
    }
}