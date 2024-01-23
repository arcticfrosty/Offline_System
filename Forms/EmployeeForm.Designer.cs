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
            comboEmpY = new ComboBox();
            comboEmpD = new ComboBox();
            comboEmpM = new ComboBox();
            textEmpDateY = new TextBox();
            textEmpDateD = new TextBox();
            label9 = new Label();
            textEmpDateM = new TextBox();
            label8 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            textEmpName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textEmpId = new TextBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            grd_emp = new DataGridView();
            label3 = new Label();
            groupBox1 = new GroupBox();
            editBtn = new Button();
            deleteBtn = new Button();
            groupBox2 = new GroupBox();
            label7 = new Label();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            inputField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_emp).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            inputField.Controls.Add(comboEmpY);
            inputField.Controls.Add(comboEmpD);
            inputField.Controls.Add(comboEmpM);
            inputField.Controls.Add(textEmpDateY);
            inputField.Controls.Add(textEmpDateD);
            inputField.Controls.Add(label9);
            inputField.Controls.Add(textEmpDateM);
            inputField.Controls.Add(label8);
            inputField.Controls.Add(radioButton3);
            inputField.Controls.Add(radioButton2);
            inputField.Controls.Add(radioButton1);
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
            // comboEmpY
            // 
            comboEmpY.FormattingEnabled = true;
            comboEmpY.Location = new Point(264, 134);
            comboEmpY.Name = "comboEmpY";
            comboEmpY.RightToLeft = RightToLeft.Yes;
            comboEmpY.Size = new Size(90, 23);
            comboEmpY.TabIndex = 24;
            // 
            // comboEmpD
            // 
            comboEmpD.FormattingEnabled = true;
            comboEmpD.Location = new Point(202, 134);
            comboEmpD.Name = "comboEmpD";
            comboEmpD.RightToLeft = RightToLeft.Yes;
            comboEmpD.Size = new Size(56, 23);
            comboEmpD.TabIndex = 23;
            // 
            // comboEmpM
            // 
            comboEmpM.FormattingEnabled = true;
            comboEmpM.Location = new Point(106, 134);
            comboEmpM.Name = "comboEmpM";
            comboEmpM.RightToLeft = RightToLeft.Yes;
            comboEmpM.Size = new Size(90, 23);
            comboEmpM.TabIndex = 22;
            // 
            // textEmpDateY
            // 
            textEmpDateY.Enabled = false;
            textEmpDateY.Location = new Point(264, 105);
            textEmpDateY.Name = "textEmpDateY";
            textEmpDateY.Size = new Size(90, 23);
            textEmpDateY.TabIndex = 18;
            textEmpDateY.TextAlign = HorizontalAlignment.Right;
            // 
            // textEmpDateD
            // 
            textEmpDateD.Enabled = false;
            textEmpDateD.Location = new Point(202, 105);
            textEmpDateD.Name = "textEmpDateD";
            textEmpDateD.Size = new Size(56, 23);
            textEmpDateD.TabIndex = 17;
            textEmpDateD.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 108);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 15;
            label9.Text = "Date";
            // 
            // textEmpDateM
            // 
            textEmpDateM.Enabled = false;
            textEmpDateM.Location = new Point(106, 105);
            textEmpDateM.Name = "textEmpDateM";
            textEmpDateM.Size = new Size(90, 23);
            textEmpDateM.TabIndex = 14;
            textEmpDateM.TextAlign = HorizontalAlignment.Right;
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
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(232, 80);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(80, 19);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Undefined";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(163, 80);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 11;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(106, 80);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 10;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
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
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(106, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(248, 23);
            comboBox2.TabIndex = 9;
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
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBox2);
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(106, 81);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.No;
            checkBox1.Size = new Size(59, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Active";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(106, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 23);
            comboBox1.TabIndex = 11;
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
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 561);
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
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox2;
        private Label label5;
        private RadioButton radioButton3;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        private CheckBox checkBox1;
        private Label label9;
        private TextBox textEmpDateM;
        private Label label8;
        private TextBox textEmpDateY;
        private TextBox textEmpDateD;
        private ComboBox comboEmpY;
        private ComboBox comboEmpD;
        private ComboBox comboEmpM;
    }
}
