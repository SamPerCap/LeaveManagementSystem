using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models.LeaveTypes
{
    public class LeaveTypeCreateVM
    {
        [Required]
        [Length(4, 150, ErrorMessage = "Not long enough")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(1,90)]
        public int NumberOfDays { get; set; }
    }
}
