using Offline_System.Models.Data;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Offline_System {
    public partial class PositionFrm : Form {
        public PositionFrm() {
            InitializeComponent();
        }

        private void PositionFrm_Load(object sender, EventArgs e) {
            getPositions();
        }

        protected void getPositions() {
            var _context = new OfflineDbContext();
            var posList = _context.C_Positions.ToList();
            grd_pos.DataSource = posList;

            grd_pos.Columns[0].HeaderText = "ID";
            grd_pos.Columns[1].HeaderText = "Position Name";
            grd_pos.Columns[2].HeaderText = "Department";
            foreach (DataGridViewColumn columns in grd_pos.Columns) {
                columns.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            comboPosDep.Items.Clear();
            var depList = _context.C_Departments.ToList();
            grd_dep_list.DataSource = depList;
            foreach (DataGridViewRow rows in grd_dep_list.Rows) {
                if (!rows.IsNewRow) {
                    object depName = rows.Cells[1].Value;
                    object cellValue = rows.Cells[2].Value;
                    if (cellValue != null && (bool)cellValue) {
                        if (depName != null) {
                            comboPosDep.Items.Add(depName.ToString());
                        }
                    }
                }
            }
        }

        private void SavePosBtn_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Confirm save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes) {
                try {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    var _context = new OfflineDbContext();
                    var posName = textPosName.Text;
                    if (!string.IsNullOrEmpty(posName)) {
                        if (Regex.IsMatch(posName, @"^[a-zA-Z\s]+$")) {
                            var positions = new Positions() {
                                PositionName = posName,
                                PositionDepart = comboPosDep.Text,
                            };
                            _context.C_Positions.Add(positions);
                            _context.SaveChanges();

                            textPosId.Text = null;
                            textPosName.Text = null;
                            comboPosDep.Text = null;

                            getPositions();

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
                    MessageBox.Show("An Error Occurred: " + "\n" + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editPosBtn_Click(object sender, EventArgs e) {

        }

        private void deletePosBtn_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Confirm deletion?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes) {
                try {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    var _context = new OfflineDbContext();
                    var posId = textPosId.Text;
                    var posName = textPosName.Text;

                    if (!string.IsNullOrEmpty(posName)) {
                        var positions = new Positions() {
                            PositionID = Convert.ToInt32(posId),
                            PositionName = posName,
                            PositionDepart = comboPosDep.Text,
                        };
                        _context.C_Positions.Remove(positions);
                        _context.SaveChanges();

                        textPosId.Text = null;
                        textPosName.Text = null;
                        comboPosDep.Text = null;

                        getPositions();

                        stopwatch.Stop();
                        long elapsedTime = stopwatch.ElapsedMilliseconds;
                        MessageBox.Show("Successfully deleted.\nElapsed: " + elapsedTime + "ms", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        MessageBox.Show("Please select one from field below!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception) {
                    MessageBox.Show("Not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grd_pos_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                textPosId.Text = grd_pos.SelectedCells[0].Value.ToString();
                textPosName.Text = grd_pos.SelectedCells[1].Value.ToString();
                comboPosDep.Text = grd_pos.SelectedCells[2].Value.ToString();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
