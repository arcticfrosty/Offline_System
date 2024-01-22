namespace Offline_System {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (message == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e) {
            var employeefrm = new EmployeeForm();
            employeefrm.Show();
        }
    }
}
