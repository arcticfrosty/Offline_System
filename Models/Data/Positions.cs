using System.ComponentModel.DataAnnotations;

namespace Offline_System.Models.Data {
    public class Positions {
        [Key] public int PositionId { get; set; }
        public string PositionName { get; set; }
    }
}
