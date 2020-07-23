using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeaveManagementSystem.DataModels
{
    public class LeaveType
    {
        [Key]
        public int LeaveId { get; set; }
        public string Leave { get; set; }
        [MaxLength(20)]
        public string LeaveDescription { get; set; }
        [MaxLength(2000)]
        public int NumberOfLeaves { get; set; }

    }
}
