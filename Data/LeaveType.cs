using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Data
{
    public class LeaveType
    {
        [Key]
        public int LeaveTypeId { get; set; }
        [Display(Name = "Leave type name")]
        [Column(TypeName = "nvarchar(150)")]
        public string LeaveTypeName { get; set; }
        [Display(Name = "Number of days")]
        public int NumberOfDays { get; set; }
    }
}
