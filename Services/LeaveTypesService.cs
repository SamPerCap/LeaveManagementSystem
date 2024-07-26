using AutoMapper;
using LeaveManagementSystem.Data;
using LeaveManagementSystem.Models.LeaveTypes;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Services
{
    public class LeaveTypesService : ILeaveTypesService
    {
        private readonly LeaveManagementDbContext _dbContext;
        private readonly IMapper _mapper;

        public LeaveTypesService(LeaveManagementDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<LeaveTypeVM>> GetAll()
        {
            return _mapper.Map<List<LeaveTypeVM>>(await _dbContext.LeaveTypes.ToListAsync());
        }

        public async Task<T?> Get<T>(int id) where T : class
        {
            var data = await _dbContext.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);

            if (data is null)
            {
                return null;
            }

            var viewData = _mapper.Map<T>(data);
            return viewData;
        }

        public async Task Remove(int id)
        {
            var data = await _dbContext.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);

            if (data is not null)
            {
                _dbContext.Remove(data);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<bool> CheckIfLeaveTypeNameExists(string name)
        {
            return await _dbContext.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(name.ToLower()));
        }

        public bool LeaveTypeExists(int id)
        {
            return _dbContext.LeaveTypes.Any(x => x.Id == id);
        }

        public async Task Edit(LeaveTypeEditVM leaveTypeEditVM)
        {
            var leaveType = _mapper.Map<LeaveTypeVM>(leaveTypeEditVM);
            _dbContext.Update(leaveType);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Create(LeaveTypeCreateVM leaveTypeCreateVM)
        {
            var leaveType = _mapper.Map<LeaveTypeVM>(leaveTypeCreateVM);
            _dbContext.Add(leaveType);
            await _dbContext.SaveChangesAsync();
        }
    }
}
