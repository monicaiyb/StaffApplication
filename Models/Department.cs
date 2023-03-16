using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace StaffApplication.Models
{
    public class Department
    {
       
            public int ID { get; set; }
            
            public string? DepartmentName { get; set; }

          public string? DepartmentPosition { get; set; }

    }
}
