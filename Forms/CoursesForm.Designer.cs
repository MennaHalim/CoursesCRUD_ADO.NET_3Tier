namespace Forms
{
    partial class CoursesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CoursesGridView = new DataGridView();
            UpdateButton = new Button();
            AddButton = new Button();
            DeleteButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)CoursesGridView).BeginInit();
            SuspendLayout();
            // 
            // CoursesGridView
            // 
            CoursesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesGridView.Location = new Point(54, 104);
            CoursesGridView.Name = "CoursesGridView";
            CoursesGridView.RowHeadersWidth = 51;
            CoursesGridView.Size = new Size(682, 258);
            CoursesGridView.TabIndex = 0;
            CoursesGridView.CellFormatting += CoursesGridView_CellFormatting;
            CoursesGridView.SelectionChanged += CoursesGridView_SelectionChanged;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(254, 397);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(131, 29);
            UpdateButton.TabIndex = 9;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(54, 69);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(127, 29);
            AddButton.TabIndex = 10;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(412, 397);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(124, 29);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 46);
            label1.TabIndex = 12;
            label1.Text = "Courses";
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(UpdateButton);
            Controls.Add(CoursesGridView);
            Name = "CoursesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CoursesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CoursesGridView;
        private Button UpdateButton;
        private Button AddButton;
        private Button DeleteButton;
        private Label label1;
    }
}
