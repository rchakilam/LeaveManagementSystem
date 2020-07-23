using System;
using System.Collections.Generic;
using System.Text;
using LeaveManagementSystem.DataModels;
using Microsoft.EntityFrameworkCore;
namespace LeaveManagementSystem.DataAccessLayer
{
    public class LMSContext : DbContext
    {
        public LMSContext(DbContextOptions<LMSContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeLeaveDetails> EmployeeLeaveDetails { get; set; }
        public DbSet<EmployeeLogin> EmployeeLogins { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Employee Leave Details
            // modelBuilder.Entity<Employee>()
            //.HasOne<EmployeeLeaveDetails>(s => s.EmployeeLeaveDetails)
            //.WithMany(g => g.Employees)
            //.HasForeignKey(s => s.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany<EmployeeLeaveDetails>(g => g.EmployeeLeaveDetails)
                .WithOne(s => s.Employees)
                .HasForeignKey(s => s.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
