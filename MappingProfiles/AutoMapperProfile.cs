using AutoMapper;
using LeaveManagementSystem.Data;
using LeaveManagementSystem.Models.LeaveTypes;

namespace LeaveManagementSystem.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LeaveType, LeaveTypeVM>();
            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
        }
    }
}
