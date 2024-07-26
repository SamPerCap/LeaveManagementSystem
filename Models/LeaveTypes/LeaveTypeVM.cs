
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models.LeaveTypes
{
    public class LeaveTypeVM : BaseLeaveTypeVM
    {
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Maximum Allocation of Days")]
        public int NumberOfDays { get; set; }
    }
}
