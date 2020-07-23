using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.DataModels
{
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }
        [MaxLength(11)]

        [ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Title { get; set; }
        [MaxLength(5)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string MiddleName { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoin { get; set; }
        public string MaritalStatus { get; set; }
        [MaxLength(1)]
        public string Designation { get; set; }
        [MaxLength(30)]
        public string ContactNumber { get; set; }
        [MaxLength(14)]
        public string EmergencyContactNumber { get; set; }
        [MaxLength(14)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string LinkedinURL { get; set; }
        public string Experience { get; set; }
        [MaxLength(5)]
        public Double Salary { get; set; }
        public DateTime LastWorkingDay { get; set; }

        public ICollection<EmployeeLeaveDetails> EmployeeLeaveDetails { get; set; }
    }
}
