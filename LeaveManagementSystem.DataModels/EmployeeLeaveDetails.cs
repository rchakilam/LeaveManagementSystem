using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeaveManagementSystem.DataModels
{
    public class EmployeeLeaveDetails
    {


        [Column(Order = 1)]
        public string EmployeeId { get; set; }
        [MaxLength(11)]

        [Key]
        [Column(Order = 2)]
        public int EmployeeLeaveId { get; set; }
        [MaxLength(11)]

        public int LeaveId { get; set; }
        [MaxLength(1)]
        public string Reason { get; set; }
        [MaxLength(2000)]
        public DateTime LeaveAppliedOn { get; set; }        
        public bool Approval { get; set; }
        public DateTime LeaveApprovedOn { get; set; }
        public DateTime LeaveFromDate { get; set; }
        public DateTime LeaveToDate { get; set; }
        public bool FullOrFirstHalf { get; set; }
        public bool FullOrSecondHalf { get; set; }
        public Employee Employees { get; set; }
    }
}
