using Offline_System.Models.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Offline_System {
    public partial class DepartmentFrm : Form {
        public DepartmentFrm() {
            InitializeComponent();
        }

        private void DepartmentFrm_Load(object sender, EventArgs e) {
            getDepartments();
            grd_dep.Columns[0].HeaderText = "ID";
            grd_dep.Columns[1].HeaderText = "Department Name";
            grd_dep.Columns[2].HeaderText = "Status";
            foreach (DataGridViewColumn columns in grd_dep.Columns) {
                columns.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        protected void getDepartments() {
            var _context = new OfflineDbContext();
            var depList = _context.OS_Departments.ToList();
            grd_dep.DataSource = depList;
        }

        private void SaveDepBtn_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Confirm save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes) {
                try {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    var _context = new OfflineDbContext();
                    var deparmentName = textDepName.Text;
                    if (!string.IsNullOrEmpty(deparmentName)) {
                        if (Regex.IsMatch(deparmentName, @"^[a-zA-Z\s]+$")) {
                            var deparment = new Departments() {
                                DepartName = deparmentName,
                                DepartStatus = depStatus.Checked,
                            };
                            _context.Add(deparment);
                            _context.SaveChanges();

                            textDepId.Text = null;
                            textDepName.Text = null;
                            depStatus.Checked = true;

                            getDepartments();

                            stopwatch.Stop();
                            long elapsedTime = stopwatch.ElapsedMilliseconds;
                            MessageBox.Show("Successfully saved.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else {
                            MessageBox.Show("Deparment name contain letters only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else {
                        MessageBox.Show("Department name field is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex) {
                    MessageBox.Show("An Error Occurred: " + "\n" + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editDepBtn_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Confirm update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes) {
                try {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    var _context = new OfflineDbContext();
                    var deparmentId = textDepId.Text;
                    var deparmentName = textDepName.Text;
                    if (!string.IsNullOrEmpty(deparmentName)) {
                        if (!string.IsNullOrEmpty(deparmentId)) {
                            if (Regex.IsMatch(deparmentName, @"^[a-zA-Z\s]+$")) {
                                var department = new Departments() {
                                    DepartID = Convert.ToInt32(deparmentId),
                                    DepartName = deparmentName,
                                    DepartStatus = depStatus.Checked,
                                };
                                _context.OS_Departments.Update(department);
                                _context.SaveChanges();

                                textDepId.Text = null;
                                textDepName.Text = null;
                                depStatus.Checked = true;

                                getDepartments();

                                stopwatch.Stop();
                                long elapsedTime = stopwatch.ElapsedMilliseconds;
                                MessageBox.Show("Successfully updated.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else {
                                MessageBox.Show("Deparment name contain letters only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } else {
                            MessageBox.Show("Please select one from field below!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else {
                        MessageBox.Show("Please select one from field below!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex) {
                    MessageBox.Show("An Error Occurred: " + "\n" + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteDepBtn_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Confirm deletion?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes) {
                try {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    var _context = new OfflineDbContext();
                    var deparmentId = textDepId.Text;
                    var departmentName = textDepName.Text;

                    if (!string.IsNullOrEmpty(departmentName)) {
                        var deparment = new Departments() {
                            DepartID = Convert.ToInt32(deparmentId),
                            DepartName = departmentName,
                            DepartStatus = depStatus.Checked,
                        };
                        _context.OS_Departments.Remove(deparment);
                        _context.SaveChanges();

                        textDepId.Text = null;
                        textDepName.Text = null;
                        depStatus.Checked = true;

                        getDepartments();

                        stopwatch.Stop();
                        long elapsedTime = stopwatch.ElapsedMilliseconds;
                        MessageBox.Show("Successfully deleted.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        MessageBox.Show("Department name field is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception) {
                    MessageBox.Show("Not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grd_dep_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                textDepId.Text = grd_dep.SelectedCells[0].Value.ToString();
                textDepName.Text = grd_dep.SelectedCells[1].Value.ToString();
                bool isActive = (bool)grd_dep.SelectedCells[2].Value;
                if (isActive) {
                    depStatus.Checked = true;
                } else {
                    depStatus.Checked = false;
                }
            } catch {
            }
        }
    }
}
