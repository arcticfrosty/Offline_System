using Offline_System.Models.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Offline_System {
    public partial class EmployeeForm : Form {

        private readonly string[] _months =
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December",
        };

        public EmployeeForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            int _startYear = 1980;
            int _endYear = DateTime.Now.Year;

            foreach (string s in _months) {
                comboEmpM.Items.Add(s);
            }
            for (int i = 1; i <= 31; i++) {
                comboEmpD.Items.Add(i);
            }
            for (int i = _startYear; i <= _endYear; i++) {
                comboEmpY.Items.Add(i);
            }

            getEmployees();
        }

        protected void getEmployees() {
            var _context = new OfflineDbContext();
            var empList = _context.ContEmployee.ToList();
            grd_emp.DataSource = empList;
        }

        protected string getGender() {
            if (rbMale.Checked == true) {
                return "Male";
            } else if (rbFemale.Checked == true) {
                return "Female";
            } else {
                return "Undefined";
            }
        }

        protected DateTime getBirthday() {
            var _dob = comboEmpM.Text + "/" + comboEmpD.Text + "/" + comboEmpY.Text;
            DateTime _dobInput = DateTime.ParseExact(_dob, "MMMM/dd/yyyy", null);
            return _dobInput;
        }

        protected bool getStatus() {
            if (empStatus.Checked == true) {
                return true;
            }
            return false;
        }

        private void SaveBtn_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Confirm save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes) {
                try {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    var _context = new OfflineDbContext();
                    var employeeName = textEmpName.Text;
                    if (!string.IsNullOrEmpty(employeeName)) {
                        if (Regex.IsMatch(employeeName, @"^[a-zA-Z\s]+$")) {
                            var employee = new Employees() {
                                EmployeesName = employeeName,
                                EmployeeGender = getGender(),
                                EmployeeAge = Convert.ToInt32(textEmpAge),
                                EmployeeDoB = getBirthday(),
                                EmployeePosition = empPos.Text,
                                EmployeeDeparment = empDepart.Text,
                            };
                            _context.ContEmployee.Add(employee);
                            _context.SaveChanges();

                            textEmpId.Text = null;
                            textEmpName.Text = null;

                            getEmployees();

                            stopwatch.Stop();
                            long elapsedTime = stopwatch.ElapsedMilliseconds;
                            MessageBox.Show("Successfully saved.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else {
                            MessageBox.Show("Name contain letters only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else {
                        MessageBox.Show("Name field is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex) {
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
                    var _context = new OfflineDbContext();
                    var employeeId = textEmpId.Text;
                    var employeeName = textEmpName.Text;
                    if (!string.IsNullOrEmpty(employeeName)) {
                        if (!string.IsNullOrEmpty(employeeId)) {
                            if (Regex.IsMatch(employeeName, @"^[a-zA-Z\s]+$")) {
                                var employee = new Employees() {
                                    EmployeesID = Convert.ToInt32(employeeId),
                                    EmployeesName = employeeName,
                                    EmployeeGender = getGender(),
                                    EmployeeAge = Convert.ToInt32(textEmpAge),
                                };
                                _context.ContEmployee.Update(employee);
                                _context.SaveChanges();

                                textEmpId.Text = null;
                                textEmpName.Text = null;

                                getEmployees();

                                stopwatch.Stop();
                                long elapsedTime = stopwatch.ElapsedMilliseconds;
                                MessageBox.Show("Successfully updated.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else {
                                MessageBox.Show("Name contain letters only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } else {
                            MessageBox.Show("Please select one from field below!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else {
                        MessageBox.Show("Name field is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex) {
                    MessageBox.Show("An Error Occurred! " + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Confirm deletion?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (message == DialogResult.Yes) {
                try {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    var _context = new OfflineDbContext();
                    var employeeId = textEmpId.Text;
                    var employeeName = textEmpName.Text;

                    if (!string.IsNullOrEmpty(employeeName)) {
                        var employee = new Employees() {
                            EmployeesID = Convert.ToInt32(employeeId),
                            EmployeesName = employeeName,
                            EmployeeGender = getGender(),
                            EmployeeAge = Convert.ToInt32(textEmpAge),
                        };
                        _context.ContEmployee.Remove(employee);
                        _context.SaveChanges();

                        textEmpId.Text = null;
                        textEmpName.Text = null;

                        getEmployees();

                        stopwatch.Stop();
                        long elapsedTime = stopwatch.ElapsedMilliseconds;
                        MessageBox.Show("Successfully deleted.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        MessageBox.Show("Name field is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch {
                    MessageBox.Show("Not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grd_emp_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                textEmpId.Text = grd_emp.SelectedCells[0].Value.ToString();
                textEmpName.Text = grd_emp.SelectedCells[1].Value.ToString();
            } catch {
            }
        }
    }
}
