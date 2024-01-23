namespace Offline_System {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void showForm(Form frm) {
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                var message = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.No) {
                    e.Cancel = true;
                } else {
                    this.FormClosing -= MainForm_FormClosing;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e) {
            var employeefrm = new EmployeeForm();
            showForm(employeefrm);
        }

        private void manageDepartmentsToolStripMenuItem_Click(object sender, EventArgs e) {
            var departfrm = new DepartmentFrm();
            showForm(departfrm);
        }
    }
}
