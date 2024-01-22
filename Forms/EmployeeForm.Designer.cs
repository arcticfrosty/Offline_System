namespace Offline_System
{
    partial class EmployeeForm
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
        private void InitializeComponent() {
            SaveBtn = new Button();
            inputField = new GroupBox();
            label4 = new Label();
            textBox2 = new TextBox();
            textEmpName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textEmpId = new TextBox();
            grd_emp = new DataGridView();
            label3 = new Label();
            groupBox1 = new GroupBox();
            editBtn = new Button();
            deleteBtn = new Button();
            inputField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_emp).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(6, 22);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(138, 23);
            SaveBtn.TabIndex = 1;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // inputField
            // 
            inputField.Controls.Add(label4);
            inputField.Controls.Add(textBox2);
            inputField.Controls.Add(textEmpName);
            inputField.Controls.Add(label2);
            inputField.Controls.Add(label1);
            inputField.Controls.Add(textEmpId);
            inputField.Location = new Point(12, 57);
            inputField.Name = "inputField";
            inputField.Size = new Size(350, 113);
            inputField.TabIndex = 3;
            inputField.TabStop = false;
            inputField.Text = "&Input Field";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Position";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(106, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 23);
            textBox2.TabIndex = 7;
            // 
            // textEmpName
            // 
            textEmpName.Location = new Point(106, 51);
            textEmpName.Name = "textEmpName";
            textEmpName.Size = new Size(238, 23);
            textEmpName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Employee Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Employee ID";
            // 
            // textEmpId
            // 
            textEmpId.Enabled = false;
            textEmpId.Location = new Point(106, 22);
            textEmpId.Name = "textEmpId";
            textEmpId.Size = new Size(238, 23);
            textEmpId.TabIndex = 3;
            // 
            // grd_emp
            // 
            grd_emp.AllowUserToAddRows = false;
            grd_emp.AllowUserToDeleteRows = false;
            grd_emp.AllowUserToResizeColumns = false;
            grd_emp.AllowUserToResizeRows = false;
            grd_emp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_emp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_emp.Location = new Point(12, 176);
            grd_emp.Name = "grd_emp";
            grd_emp.RightToLeft = RightToLeft.No;
            grd_emp.RowTemplate.Height = 25;
            grd_emp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_emp.Size = new Size(776, 262);
            grd_emp.TabIndex = 4;
            grd_emp.CellDoubleClick += grd_emp_CellDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(387, 45);
            label3.TabIndex = 5;
            label3.Text = "&Employees Management";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(editBtn);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Location = new Point(638, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 113);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "&Actions";
            // 
            // editBtn
            // 
            editBtn.Location = new Point(6, 51);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(138, 23);
            editBtn.TabIndex = 3;
            editBtn.Text = "Update";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(6, 79);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(138, 23);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(grd_emp);
            Controls.Add(inputField);
            Name = "EmployeeForm";
            Text = "Employees Management";
            Load += MainForm_Load;
            inputField.ResumeLayout(false);
            inputField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd_emp).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveBtn;
        private GroupBox inputField;
        private TextBox textEmpName;
        private Label label2;
        private Label label1;
        private TextBox textEmpId;
        private DataGridView grd_emp;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Button editBtn;
        private Button deleteBtn;
    }
}
