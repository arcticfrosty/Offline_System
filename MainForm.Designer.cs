namespace Offline_System {
    partial class MainForm {
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            departmentsToolStripMenuItem1 = new ToolStripMenuItem();
            manageDepartmentsToolStripMenuItem = new ToolStripMenuItem();
            managePositionsToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem1 = new ToolStripMenuItem();
            manageEmployeesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem , departmentsToolStripMenuItem1 , employeesToolStripMenuItem1 });
            menuStrip1.Location = new Point(0 , 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784 , 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37 , 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93 , 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // departmentsToolStripMenuItem1
            // 
            departmentsToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { manageDepartmentsToolStripMenuItem , managePositionsToolStripMenuItem });
            departmentsToolStripMenuItem1.Name = "departmentsToolStripMenuItem1";
            departmentsToolStripMenuItem1.Size = new Size(87 , 20);
            departmentsToolStripMenuItem1.Text = "Departments";
            // 
            // manageDepartmentsToolStripMenuItem
            // 
            manageDepartmentsToolStripMenuItem.Name = "manageDepartmentsToolStripMenuItem";
            manageDepartmentsToolStripMenuItem.Size = new Size(188 , 22);
            manageDepartmentsToolStripMenuItem.Text = "Manage Departments";
            manageDepartmentsToolStripMenuItem.Click += manageDepartmentsToolStripMenuItem_Click;
            // 
            // managePositionsToolStripMenuItem
            // 
            managePositionsToolStripMenuItem.Name = "managePositionsToolStripMenuItem";
            managePositionsToolStripMenuItem.Size = new Size(188 , 22);
            managePositionsToolStripMenuItem.Text = "Manage Positions";
            managePositionsToolStripMenuItem.Click += managePositionsToolStripMenuItem_Click;
            // 
            // employeesToolStripMenuItem1
            // 
            employeesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { manageEmployeesToolStripMenuItem });
            employeesToolStripMenuItem1.Name = "employeesToolStripMenuItem1";
            employeesToolStripMenuItem1.Size = new Size(76 , 20);
            employeesToolStripMenuItem1.Text = "Employees";
            // 
            // manageEmployeesToolStripMenuItem
            // 
            manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            manageEmployeesToolStripMenuItem.Size = new Size(177 , 22);
            manageEmployeesToolStripMenuItem.Text = "Manage Employees";
            manageEmployeesToolStripMenuItem.Click += manageEmployeesToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F , 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784 , 411);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800 , 450);
            Name = "MainForm";
            Text = "Offline System";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem departmentsToolStripMenuItem1;
        private ToolStripMenuItem manageDepartmentsToolStripMenuItem;
        private ToolStripMenuItem managePositionsToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem1;
        private ToolStripMenuItem manageEmployeesToolStripMenuItem;
    }
}