namespace Offline_System {
    partial class PositionFrm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            groupBox1 = new GroupBox();
            editPosBtn = new Button();
            deletePosBtn = new Button();
            SavePosBtn = new Button();
            label3 = new Label();
            grd_pos = new DataGridView();
            inputField = new GroupBox();
            label4 = new Label();
            comboPosDep = new ComboBox();
            textPosName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textPosId = new TextBox();
            grd_dep_list = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_pos).BeginInit();
            inputField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_dep_list).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(editPosBtn);
            groupBox1.Controls.Add(deletePosBtn);
            groupBox1.Controls.Add(SavePosBtn);
            groupBox1.Location = new Point(622, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(150, 139);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "&Actions";
            // 
            // editPosBtn
            // 
            editPosBtn.Location = new Point(6, 51);
            editPosBtn.Name = "editPosBtn";
            editPosBtn.Size = new Size(138, 23);
            editPosBtn.TabIndex = 3;
            editPosBtn.Text = "Update";
            editPosBtn.UseVisualStyleBackColor = true;
            editPosBtn.Click += editPosBtn_Click;
            // 
            // deletePosBtn
            // 
            deletePosBtn.Location = new Point(6, 79);
            deletePosBtn.Name = "deletePosBtn";
            deletePosBtn.Size = new Size(138, 23);
            deletePosBtn.TabIndex = 2;
            deletePosBtn.Text = "Delete";
            deletePosBtn.UseVisualStyleBackColor = true;
            deletePosBtn.Click += deletePosBtn_Click;
            // 
            // SavePosBtn
            // 
            SavePosBtn.Location = new Point(6, 22);
            SavePosBtn.Name = "SavePosBtn";
            SavePosBtn.Size = new Size(138, 23);
            SavePosBtn.TabIndex = 1;
            SavePosBtn.Text = "Save";
            SavePosBtn.UseVisualStyleBackColor = true;
            SavePosBtn.Click += SavePosBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(363, 45);
            label3.TabIndex = 13;
            label3.Text = "&Positions Management";
            // 
            // grd_pos
            // 
            grd_pos.AllowUserToAddRows = false;
            grd_pos.AllowUserToDeleteRows = false;
            grd_pos.AllowUserToResizeColumns = false;
            grd_pos.AllowUserToResizeRows = false;
            grd_pos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grd_pos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_pos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_pos.Location = new Point(12, 202);
            grd_pos.Name = "grd_pos";
            grd_pos.ReadOnly = true;
            grd_pos.RightToLeft = RightToLeft.No;
            grd_pos.RowHeadersVisible = false;
            grd_pos.RowTemplate.Height = 25;
            grd_pos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_pos.Size = new Size(760, 347);
            grd_pos.TabIndex = 12;
            grd_pos.CellDoubleClick += grd_pos_CellDoubleClick;
            // 
            // inputField
            // 
            inputField.Controls.Add(label4);
            inputField.Controls.Add(comboPosDep);
            inputField.Controls.Add(textPosName);
            inputField.Controls.Add(label2);
            inputField.Controls.Add(label1);
            inputField.Controls.Add(textPosId);
            inputField.Location = new Point(12, 57);
            inputField.Name = "inputField";
            inputField.Size = new Size(358, 139);
            inputField.TabIndex = 11;
            inputField.TabStop = false;
            inputField.Text = "&Position Info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 16;
            label4.Text = "Department Name";
            // 
            // comboPosDep
            // 
            comboPosDep.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPosDep.FormattingEnabled = true;
            comboPosDep.Location = new Point(117, 80);
            comboPosDep.Name = "comboPosDep";
            comboPosDep.Size = new Size(235, 23);
            comboPosDep.TabIndex = 15;
            // 
            // textPosName
            // 
            textPosName.Location = new Point(117, 50);
            textPosName.Name = "textPosName";
            textPosName.Size = new Size(235, 23);
            textPosName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 5;
            label2.Text = "Position Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "Position ID";
            // 
            // textPosId
            // 
            textPosId.Enabled = false;
            textPosId.Location = new Point(117, 22);
            textPosId.Name = "textPosId";
            textPosId.Size = new Size(235, 23);
            textPosId.TabIndex = 3;
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
            grd_dep_list.Location = new Point(622, 202);
            grd_dep_list.Name = "grd_dep_list";
            grd_dep_list.ReadOnly = true;
            grd_dep_list.RightToLeft = RightToLeft.No;
            grd_dep_list.RowHeadersVisible = false;
            grd_dep_list.RowTemplate.Height = 25;
            grd_dep_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_dep_list.Size = new Size(150, 347);
            grd_dep_list.TabIndex = 15;
            grd_dep_list.Visible = false;
            // 
            // PositionFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(grd_dep_list);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(grd_pos);
            Controls.Add(inputField);
            Name = "PositionFrm";
            Text = "Positions Management";
            Load += PositionFrm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd_pos).EndInit();
            inputField.ResumeLayout(false);
            inputField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd_dep_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button editPosBtn;
        private Button deletePosBtn;
        private Button SavePosBtn;
        private Label label3;
        private DataGridView grd_pos;
        private GroupBox inputField;
        private TextBox textPosName;
        private Label label2;
        private Label label1;
        private TextBox textPosId;
        private Label label4;
        private ComboBox comboPosDep;
        private DataGridView grd_dep_list;
    }
}