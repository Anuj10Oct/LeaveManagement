using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<Employee> Employees { get; set; }
        DbSet<LeaveType> LeaveTypes { get; set; }
        DbSet<LeaveAllocation> leaveAllocations { get; set; }
        DbSet<LeaveHistory> LeaveHistories { get; set; }
    }
}
