using Offline_System.Models.Data;

namespace Offline_System {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void SaveBtn_Click(object sender, EventArgs e) {
            var _context = new DemoDbContext();
            var employee = new Employees()
            {
                EmployeesName = "Sintav",
            };

            _context.employees.Add(employee);
            _context.SaveChanges();
        }

        private void delBtn_Click(object sender, EventArgs e) {
            var _context = new DemoDbContext();
            var employee = new Employees()
            {
                EmployeesName = "Sintav",
            };
            _context.Remove(employee);
            _context.SaveChanges();
        }
    }
}
