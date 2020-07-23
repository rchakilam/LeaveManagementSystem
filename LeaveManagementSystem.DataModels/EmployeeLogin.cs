using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeaveManagementSystem.DataModels
{
    public class EmployeeLogin
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set;}
        [MaxLength(1000)]
        public string Password { get; set; }
        [MaxLength(250)]
        public DateTime LastLogin { get; set; }        
        public int Counter { get; set; }

    }
}
