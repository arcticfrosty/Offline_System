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
            textEmpDob = new DateTimePicker();
            label9 = new Label();
            textEmpAge = new TextBox();
            label8 = new Label();
            rbUndef = new RadioButton();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label5 = new Label();
            textEmpName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textEmpId = new TextBox();
            empDepart = new ComboBox();
            label4 = new Label();
            grd_emp = new DataGridView();
            label3 = new Label();
            groupBox1 = new GroupBox();
            clearBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            groupBox2 = new GroupBox();
            label7 = new Label();
            empStatus = new CheckBox();
            empPos = new ComboBox();
            label6 = new Label();
            grd_dep_list = new DataGridView();
            inputField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_emp).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_dep_list).BeginInit();
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
            inputField.Controls.Add(textEmpDob);
            inputField.Controls.Add(label9);
            inputField.Controls.Add(textEmpAge);
            inputField.Controls.Add(label8);
            inputField.Controls.Add(rbUndef);
            inputField.Controls.Add(rbFemale);
            inputField.Controls.Add(rbMale);
            inputField.Controls.Add(label5);
            inputField.Controls.Add(textEmpName);
            inputField.Controls.Add(label2);
            inputField.Controls.Add(label1);
            inputField.Controls.Add(textEmpId);
            inputField.Location = new Point(12, 57);
            inputField.Name = "inputField";
            inputField.Size = new Size(360, 166);
            inputField.TabIndex = 3;
            inputField.TabStop = false;
            inputField.Text = "&Employee Info";
            // 
            // textEmpDob
            // 
            textEmpDob.Format = DateTimePickerFormat.Short;
            textEmpDob.Location = new Point(106, 134);
            textEmpDob.Name = "textEmpDob";
            textEmpDob.RightToLeft = RightToLeft.No;
            textEmpDob.Size = new Size(248, 23);
            textEmpDob.TabIndex = 14;
            textEmpDob.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 108);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 26;
            label9.Text = "Age";
            // 
            // textEmpAge
            // 
            textEmpAge.Location = new Point(106, 105);
            textEmpAge.Name = "textEmpAge";
            textEmpAge.Size = new Size(51, 23);
            textEmpAge.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 137);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 13;
            label8.Text = "Date of birth";
            // 
            // rbUndef
            // 
            rbUndef.AutoSize = true;
            rbUndef.Checked = true;
            rbUndef.Location = new Point(232, 80);
            rbUndef.Name = "rbUndef";
            rbUndef.Size = new Size(80, 19);
            rbUndef.TabIndex = 12;
            rbUndef.TabStop = true;
            rbUndef.Text = "Undefined";
            rbUndef.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(163, 80);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 11;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(106, 80);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 10;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 82);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 7;
            label5.Text = "Sex";
            // 
            // textEmpName
            // 
            textEmpName.Location = new Point(106, 51);
            textEmpName.Name = "textEmpName";
            textEmpName.Size = new Size(248, 23);
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
            textEmpId.Size = new Size(248, 23);
            textEmpId.TabIndex = 3;
            // 
            // empDepart
            // 
            empDepart.DropDownStyle = ComboBoxStyle.DropDownList;
            empDepart.FormattingEnabled = true;
            empDepart.Location = new Point(106, 22);
            empDepart.Name = "empDepart";
            empDepart.Size = new Size(248, 23);
            empDepart.TabIndex = 9;
            empDepart.SelectedIndexChanged += empDepart_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 25);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 8;
            label4.Text = "Department";
            // 
            // grd_emp
            // 
            grd_emp.AllowUserToAddRows = false;
            grd_emp.AllowUserToDeleteRows = false;
            grd_emp.AllowUserToResizeColumns = false;
            grd_emp.AllowUserToResizeRows = false;
            grd_emp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grd_emp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_emp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_emp.Location = new Point(12, 229);
            grd_emp.Name = "grd_emp";
            grd_emp.ReadOnly = true;
            grd_emp.RightToLeft = RightToLeft.No;
            grd_emp.RowHeadersVisible = false;
            grd_emp.RowTemplate.Height = 25;
            grd_emp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_emp.Size = new Size(882, 320);
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
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(clearBtn);
            groupBox1.Controls.Add(editBtn);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(744, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(150, 166);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "&Actions";
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(6, 134);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(138, 23);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(empStatus);
            groupBox2.Controls.Add(empPos);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(empDepart);
            groupBox2.Location = new Point(378, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 166);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "&Role";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 82);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Status";
            // 
            // empStatus
            // 
            empStatus.AutoSize = true;
            empStatus.Checked = true;
            empStatus.CheckState = CheckState.Checked;
            empStatus.Location = new Point(106, 81);
            empStatus.Name = "empStatus";
            empStatus.RightToLeft = RightToLeft.No;
            empStatus.Size = new Size(59, 19);
            empStatus.TabIndex = 12;
            empStatus.Text = "Active";
            empStatus.UseVisualStyleBackColor = true;
            // 
            // empPos
            // 
            empPos.DropDownStyle = ComboBoxStyle.DropDownList;
            empPos.FormattingEnabled = true;
            empPos.Location = new Point(106, 51);
            empPos.Name = "empPos";
            empPos.Size = new Size(248, 23);
            empPos.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 54);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 10;
            label6.Text = "Position";
            // 
            // grd_dep_list
            // 
            grd_dep_list.AllowUserToAddRows = false;
            grd_dep_list.AllowUserToDeleteRows = false;
            grd_dep_list.AllowUserToResizeColumns = false;
            grd_dep_list.AllowUserToResizeRows = false;
            grd_dep_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grd_dep_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_dep_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_dep_list.Location = new Point(12, 229);
            grd_dep_list.Name = "grd_dep_list";
            grd_dep_list.ReadOnly = true;
            grd_dep_list.RightToLeft = RightToLeft.No;
            grd_dep_list.RowHeadersVisible = false;
            grd_dep_list.RowTemplate.Height = 25;
            grd_dep_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_dep_list.Size = new Size(100, 320);
            grd_dep_list.TabIndex = 8;
            grd_dep_list.Visible = false;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 561);
            Controls.Add(grd_dep_list);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(grd_emp);
            Controls.Add(inputField);
            MinimumSize = new Size(922, 600);
            Name = "EmployeeForm";
            Text = "Employees Management";
            Load += MainForm_Load;
            inputField.ResumeLayout(false);
            inputField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd_emp).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd_dep_list).EndInit();
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
        private GroupBox groupBox1;
        private Button editBtn;
        private Button deleteBtn;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private ComboBox empDepart;
        private Label label5;
        private RadioButton rbUndef;
        private GroupBox groupBox2;
        private ComboBox empPos;
        private Label label6;
        private Label label7;
        private CheckBox empStatus;
        private Label label8;
        private Label label9;
        private TextBox textEmpAge;
        private DateTimePicker textEmpDob;
        private DataGridView grd_dep_list;
        private Button clearBtn;
    }
}
