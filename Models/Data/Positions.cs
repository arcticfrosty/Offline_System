using System.ComponentModel.DataAnnotations;

namespace Offline_System.Models.Data {
    public class Positions {
        [Key] public int PositionID { get; set; }
        public string PositionName { get; set; }
        public string PositionDepart { get; set; }
    }
}
