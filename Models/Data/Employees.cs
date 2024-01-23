using System.ComponentModel.DataAnnotations;

namespace Offline_System.Models.Data {
    public class Employees {
        [Key] public int EmployeesID { get; set; }
        public string EmployeesName { get; set; }
        public string EmployeeGender { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeDeparment { get; set; }
        public string EmployeePosition { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeDate { get; set; }
    }
}
