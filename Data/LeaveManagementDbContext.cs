using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Data
{
    public class LeaveManagementDbContext : IdentityDbContext<ApplicationUser>
    {
        public LeaveManagementDbContext(DbContextOptions<LeaveManagementDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var employeeRoleGuid = "5fced614-d4a4-4edc-aa59-43cf8b3c511c";
            var supervisorRoleGuid = "da6784ee-d614-47d6-9926-7dbac73c29a4";
            var adminRoleGuid = "a65c545d-5a60-4eae-b072-655cd60b401e";

            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = employeeRoleGuid,
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = supervisorRoleGuid,
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                },
                new IdentityRole
                {
                    Id = adminRoleGuid,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );

            var adminUserGuid = "02ccb3b3-9a18-4ed6-9f5b-81c2782ab06d";
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = adminUserGuid,
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMINISTRATOR",
                UserName = "Administrator",
                PasswordHash = hasher.HashPassword(null, "admin"),
                EmailConfirmed = true,
                FirstName = "Default",
                LastName = "Admin",
                DateOfBirth = new DateOnly(2001, 01, 01)
            });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleGuid,
                    UserId = adminUserGuid
                }    
            );
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
