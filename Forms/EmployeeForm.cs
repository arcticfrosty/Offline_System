using Offline_System.Models.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

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

            if (message == DialogResult.Yes) {
                try {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    var _context = new DemoDbContext();
                    var employeeName = textEmpName.Text;
                    if (!string.IsNullOrEmpty(employeeName)) {
                        if (Regex.IsMatch(employeeName, @"^[a-zA-Z\s]+$")) {
                            var employee = new Employees()
                            {
                                EmployeesName = employeeName,
                            };
                            _context.employees.Add(employee);
                            _context.SaveChanges();

                            textEmpId.Text = null;
                            textEmpName.Text = null;

                            getEmployees();

                            stopwatch.Stop();
                            long elapsedTime = stopwatch.ElapsedMilliseconds;
                            MessageBox.Show("Successfully saved.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                            MessageBox.Show("Name contain letters only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void editBtn_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Confirm update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes) {
                try {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    var _context = new DemoDbContext();
                    var employeeId = textEmpId.Text;
                    var employeeName = textEmpName.Text;
                    if (!string.IsNullOrEmpty(employeeName)) {
                        if (!string.IsNullOrEmpty(employeeId)) {
                            if (Regex.IsMatch(employeeName, @"^[a-zA-Z\s]+$")) {
                                var employee = new Employees()
                                {
                                    EmployeesID = Convert.ToInt32(employeeId),
                                    EmployeesName = employeeName,
                                };
                                _context.employees.Update(employee);
                                _context.SaveChanges();

                                textEmpId.Text = null;
                                textEmpName.Text = null;

                                getEmployees();

                                stopwatch.Stop();
                                long elapsedTime = stopwatch.ElapsedMilliseconds;
                                MessageBox.Show("Successfully updated.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else {
                                MessageBox.Show("Name contain letters only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else {
                            MessageBox.Show("Please select one from field below!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void deleteBtn_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Confirm deletion?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes) {
                try {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    var _context = new DemoDbContext();
                    var employeeId = textEmpId.Text;
                    var employeeName = textEmpName.Text;

                    if (!string.IsNullOrEmpty(employeeName)) {
                        var employee = new Employees()
                        {
                            EmployeesID = Convert.ToInt32(employeeId),
                            EmployeesName = employeeName,
                        };
                        _context.employees.Remove(employee);
                        _context.SaveChanges();

                        textEmpId.Text = null;
                        textEmpName.Text = null;

                        getEmployees();

                        stopwatch.Stop();
                        long elapsedTime = stopwatch.ElapsedMilliseconds;
                        MessageBox.Show("Successfully deleted.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Name field is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception) {
                    MessageBox.Show("Value not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grd_emp_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            var employeeId = grd_emp.SelectedCells[0].Value.ToString();
            var employeeName = grd_emp.SelectedCells[1].Value.ToString();

            textEmpId.Text = employeeId;
            textEmpName.Text = employeeName;
        }
    }
}
