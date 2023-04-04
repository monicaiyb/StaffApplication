using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace StaffApplication.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }


        public string? LastName { get; set; }

        public string? FirstName { get; set; }

        public string? Email { get; set; }
        public DateTime EmploymentDate { get; set; }

        public int DepartmentId { get; set; }


    }

}

