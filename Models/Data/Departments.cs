using System.ComponentModel.DataAnnotations;

namespace Offline_System.Models.Data {
    public class Departments {
        [Key] public int DepartId { get; set; }
        public string DepartName { get; set; }
        public bool DepartStatus { get; set; }
    }
}
