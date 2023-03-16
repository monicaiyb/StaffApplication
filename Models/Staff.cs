using System.ComponentModel.DataAnnotations;

namespace StaffApplication.Models
{
    public class Staff
    {
        public int Id { get; set; }

       
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EmploymentDate { get; set; }

        public ICollection<Department> Department { get; set; }
    }

}

