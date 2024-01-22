using Offline_System.Models.Data;
using System.Diagnostics;

namespace Offline_System {
    public partial class EmployeeForm : Form {
        public EmployeeForm() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            getEmployees();
        }

        protected void getEmployees() {
            var _context = new DemoDbContext();
            var empList = _context.employees.ToList();
            grd_emp.DataSource = empList;
        }

        private void SaveBtn_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Confirm save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (message == DialogResult.Yes) {
                try {
                    var _context = new DemoDbContext();
                    var employeeName = txtName.Text;

                    if (!string.IsNullOrEmpty(employeeName)) {
                        var employee = new Employees()
                        {
                            EmployeesName = employeeName,
                        };
                        _context.employees.Add(employee);
                        _context.SaveChanges();

                        getEmployees();

                        stopwatch.Stop();
                        long elapsedTime = stopwatch.ElapsedMilliseconds;
                        MessageBox.Show("Successfully saved.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Name field is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("An Error Occurred! " + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e) {

        }

        private void grd_emp_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            var employeeId = grd_emp.SelectedCells[0].Value.ToString();
            var employeeName = grd_emp.SelectedCells[1].Value.ToString();
            MessageBox.Show($"Employee ID: \t{employeeId}\nEmployee Name: \t{employeeName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
