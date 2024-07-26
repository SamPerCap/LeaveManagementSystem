using LeaveManagementSystem.Models.LeaveTypes;

namespace LeaveManagementSystem.Services
{
    public interface ILeaveTypesService
    {
        Task<bool> CheckIfLeaveTypeNameExists(string name);
        Task Create(LeaveTypeCreateVM leaveTypeCreateVM);
        Task Edit(LeaveTypeEditVM leaveTypeEditVM);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeVM>> GetAll();
        bool LeaveTypeExists(int id);
        Task Remove(int id);
    }
}