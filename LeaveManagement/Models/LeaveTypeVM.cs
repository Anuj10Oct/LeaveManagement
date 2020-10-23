using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name =" Date Created")]
        public DateTime? DateCreated { get; set; }
    }   
}
