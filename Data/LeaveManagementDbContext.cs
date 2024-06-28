using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Data
{
    public class LeaveManagementDbContext : IdentityDbContext
    {
        public LeaveManagementDbContext(DbContextOptions<LeaveManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
