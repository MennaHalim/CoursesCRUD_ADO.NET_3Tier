namespace Forms
{
    partial class Update_Form
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
            label1 = new Label();
            UpdateButton = new Button();
            DepartmentsComboBox = new ComboBox();
            DegreeTextBox = new TextBox();
            MinimumDegreeTextBox = new TextBox();
            NameTextBox = new TextBox();
            DepartmentIdLabel = new Label();
            MinimumDegreeLabel = new Label();
            DegreeLabel = new Label();
            CourseNamelabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 43);
            label1.Name = "label1";
            label1.Size = new Size(287, 47);
            label1.TabIndex = 28;
            label1.Text = "Update Course";
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(320, 383);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(281, 29);
            UpdateButton.TabIndex = 27;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DepartmentsComboBox
            // 
            DepartmentsComboBox.FormattingEnabled = true;
            DepartmentsComboBox.Location = new Point(320, 310);
            DepartmentsComboBox.Name = "DepartmentsComboBox";
            DepartmentsComboBox.Size = new Size(280, 28);
            DepartmentsComboBox.TabIndex = 26;
            // 
            // DegreeTextBox
            // 
            DegreeTextBox.Location = new Point(319, 195);
            DegreeTextBox.Name = "DegreeTextBox";
            DegreeTextBox.Size = new Size(281, 27);
            DegreeTextBox.TabIndex = 25;
            // 
            // MinimumDegreeTextBox
            // 
            MinimumDegreeTextBox.Location = new Point(320, 253);
            MinimumDegreeTextBox.Name = "MinimumDegreeTextBox";
            MinimumDegreeTextBox.Size = new Size(280, 27);
            MinimumDegreeTextBox.TabIndex = 24;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(319, 140);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(281, 27);
            NameTextBox.TabIndex = 23;
            // 
            // DepartmentIdLabel
            // 
            DepartmentIdLabel.AutoSize = true;
            DepartmentIdLabel.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepartmentIdLabel.Location = new Point(139, 310);
            DepartmentIdLabel.Name = "DepartmentIdLabel";
            DepartmentIdLabel.Size = new Size(101, 19);
            DepartmentIdLabel.TabIndex = 22;
            DepartmentIdLabel.Text = "Department :";
            // 
            // MinimumDegreeLabel
            // 
            MinimumDegreeLabel.AutoSize = true;
            MinimumDegreeLabel.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinimumDegreeLabel.Location = new Point(139, 253);
            MinimumDegreeLabel.Name = "MinimumDegreeLabel";
            MinimumDegreeLabel.Size = new Size(141, 19);
            MinimumDegreeLabel.TabIndex = 21;
            MinimumDegreeLabel.Text = "Minimum Degree :";
            // 
            // DegreeLabel
            // 
            DegreeLabel.AutoSize = true;
            DegreeLabel.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DegreeLabel.Location = new Point(139, 195);
            DegreeLabel.Name = "DegreeLabel";
            DegreeLabel.Size = new Size(68, 19);
            DegreeLabel.TabIndex = 20;
            DegreeLabel.Text = "Degree :";
            // 
            // CourseNamelabel
            // 
            CourseNamelabel.AutoSize = true;
            CourseNamelabel.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseNamelabel.Location = new Point(139, 144);
            CourseNamelabel.Name = "CourseNamelabel";
            CourseNamelabel.Size = new Size(116, 19);
            CourseNamelabel.TabIndex = 19;
            CourseNamelabel.Text = "Course Name : ";
            // 
            // Update_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(UpdateButton);
            Controls.Add(DepartmentsComboBox);
            Controls.Add(DegreeTextBox);
            Controls.Add(MinimumDegreeTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(DepartmentIdLabel);
            Controls.Add(MinimumDegreeLabel);
            Controls.Add(DegreeLabel);
            Controls.Add(CourseNamelabel);
            Name = "Update_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button UpdateButton;
        private ComboBox DepartmentsComboBox;
        private TextBox DegreeTextBox;
        private TextBox MinimumDegreeTextBox;
        private TextBox NameTextBox;
        private Label DepartmentIdLabel;
        private Label MinimumDegreeLabel;
        private Label DegreeLabel;
        private Label CourseNamelabel;
    }
}