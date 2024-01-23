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
        }

        protected void getDepartments() {
            var _context = new OfflineDbContext();
            var depList = _context.ContDepart.ToList();
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
                            };
                            _context.Add(deparment);
                            _context.SaveChanges();

                            textDepId.Text = null;
                            textDepName.Text = null;

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
                    MessageBox.Show("An Error Occurred! " + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                    DepartId = Convert.ToInt32(deparmentId),
                                    DepartName = deparmentName,
                                };
                                _context.ContDepart.Update(department);
                                _context.SaveChanges();

                                textDepId.Text = null;
                                textDepName.Text = null;

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
                    MessageBox.Show("An Error Occurred! " + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            DepartId = Convert.ToInt32(deparmentId),
                            DepartName = departmentName,
                        };
                        _context.ContDepart.Remove(deparment);
                        _context.SaveChanges();

                        textDepId.Text = null;
                        textDepName.Text = null;

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
            } catch {
            }
        }
    }
}
