using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace StaffApplication.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string? DepartmentName { get; set; }
        [Required]
        public string? DepartmentPosition { get; set; }


    }
}
