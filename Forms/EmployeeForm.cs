using Offline_System.Models.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Offline_System {
    public partial class EmployeeForm : Form {

        public EmployeeForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            getEmployees();
        }

        protected void getEmployees() {
            var _context = new OfflineDbContext();
            var empList = _context.OS_Employees.ToList();
            grd_emp.DataSource = empList;

            grd_emp.Columns[0].HeaderText = "ID";
            grd_emp.Columns[1].HeaderText = "Name";
            grd_emp.Columns[2].HeaderText = "Gender";
            grd_emp.Columns[3].HeaderText = "Age";
            grd_emp.Columns[4].HeaderText = "Birthday";
            grd_emp.Columns[5].HeaderText = "Position";
            grd_emp.Columns[6].HeaderText = "Department";
            grd_emp.Columns[7].HeaderText = "Status";
            foreach (DataGridViewColumn columns in grd_emp.Columns) {
                columns.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            empDepart.Items.Clear();
            var depList = _context.OS_Departments.ToList();
            grd_dep_list.DataSource = depList;
            foreach (DataGridViewRow rows in grd_dep_list.Rows) {
                if (!rows.IsNewRow) {
                    object depName = rows.Cells[1].Value;
                    object cellValue = rows.Cells[2].Value;
                    if (cellValue != null && (bool)cellValue) {
                        if (depName != null) {
                            empDepart.Items.Add(depName.ToString());
                        }
                    }
                }
            }
            var posList = _context.OS_Positions.ToList();
            grd_pos_list.DataSource = posList;
            foreach (DataGridViewRow rows in grd_pos_list.Rows) {
                if (!rows.IsNewRow) {
                    object posName = rows.Cells[1].Value;
                    if (posName != null) {
                        empPos.Items.Add(posName.ToString());
                    }
                }
            }
        }

        protected string getGender() {
            if (rbMale.Checked == true) {
                return "Male";
            } else if (rbFemale.Checked == true) {
                return "Female";
            }
            return "Undefined";
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
                            if (textEmpAge.Text != null || empPos.Text != null || empDepart.Text != null) {
                                var employee = new Employees() {
                                    EmployeesName = employeeName,
                                    EmployeeGender = getGender(),
                                    EmployeeAge = Convert.ToInt32(textEmpAge.Text),
                                    EmployeeDoB = textEmpDob.Value.Date,
                                    EmployeePosition = empPos.Text,
                                    EmployeeDeparment = empDepart.Text,
                                    EmployeeStatus = empStatus.Checked,
                                };
                                _context.OS_Employees.Add(employee);
                                _context.SaveChanges();

                                textEmpId.Text = null;
                                textEmpName.Text = null;
                                textEmpAge.Text = null;
                                textEmpDob.Value = DateTime.Parse("2000-01-01");

                                getEmployees();

                                stopwatch.Stop();
                                long elapsedTime = stopwatch.ElapsedMilliseconds;
                                MessageBox.Show("Successfully saved.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else {
                                MessageBox.Show("Please fill in all of the required information!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } else {
                            MessageBox.Show("Name contain letters only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else {
                        MessageBox.Show("Name field is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex) {
                    MessageBox.Show("An Error Occurred: " + "\n" + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                if (!(string.IsNullOrEmpty(textEmpAge.Text) || string.IsNullOrEmpty(textEmpAge.Text) || string.IsNullOrEmpty(textEmpAge.Text))) {
                                    var employee = new Employees() {
                                        EmployeesID = Convert.ToInt32(employeeId),
                                        EmployeesName = employeeName,
                                        EmployeeGender = getGender(),
                                        EmployeeAge = Convert.ToInt32(textEmpAge.Text),
                                        EmployeeDoB = textEmpDob.Value.Date,
                                        EmployeePosition = empPos.Text,
                                        EmployeeDeparment = empDepart.Text,
                                        EmployeeStatus = empStatus.Checked,
                                    };
                                    _context.OS_Employees.Update(employee);
                                    _context.SaveChanges();

                                    textEmpId.Text = null;
                                    textEmpName.Text = null;
                                    textEmpAge.Text = null;
                                    textEmpDob.Value = DateTime.Parse("2000-01-01");

                                    getEmployees();

                                    stopwatch.Stop();
                                    long elapsedTime = stopwatch.ElapsedMilliseconds;
                                    MessageBox.Show("Successfully updated.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                } else {
                                    MessageBox.Show("Please fill in all of the required information!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
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
                    MessageBox.Show("An Error Occurred: " + "\n" + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            EmployeeAge = Convert.ToInt32(textEmpAge.Text),
                            EmployeeDoB = textEmpDob.Value.Date,
                            EmployeePosition = empPos.Text,
                            EmployeeDeparment = empDepart.Text,
                            EmployeeStatus = empStatus.Checked,
                        };
                        _context.OS_Employees.Remove(employee);
                        _context.SaveChanges();

                        textEmpId.Text = null;
                        textEmpName.Text = null;
                        textEmpAge.Text = null;
                        textEmpDob.Value = DateTime.Parse("2000-01-01");

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

        private void clearBtn_Click(object sender, EventArgs e) {
            textEmpId.Text = null;
            textEmpName.Text = null;
            rbUndef.Checked = true;
            textEmpAge.Text = null;
            textEmpDob.Value = DateTime.Parse("2000-01-01");
            empDepart.Text = null;
            empPos.Text = null;
            empStatus.Checked = true;
        }

        private void grd_emp_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                textEmpId.Text = grd_emp.SelectedCells[0].Value.ToString();
                textEmpName.Text = grd_emp.SelectedCells[1].Value.ToString();
                textEmpAge.Text = grd_emp.SelectedCells[3].Value.ToString();
                textEmpDob.Value = (DateTime)grd_emp.SelectedCells[4].Value;
                if (grd_emp.SelectedCells[2].Value.ToString().Equals("Male")) {
                    rbMale.Checked = true;
                } else if (grd_emp.SelectedCells[2].Value.ToString().Equals("Female")) {
                    rbFemale.Checked = true;
                } else {
                    rbUndef.Checked = true;
                }
                bool isActive = (bool)grd_emp.SelectedCells[7].Value;
                if (isActive) {
                    empStatus.Checked = true;
                } else {
                    empStatus.Checked = false;
                }
                empDepart.Text = grd_emp.SelectedCells[6].Value.ToString();
            } catch {
            }
        }

        private void empDepart_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
