using System.ComponentModel.DataAnnotations;

namespace Offline_System.Models.Data {
    public class Employees {
        [Key]
        public int EmployeesID { get; set; }
        public string EmployeesName { get; set; }
    }
}
