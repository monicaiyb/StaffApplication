﻿using System.ComponentModel.DataAnnotations;

namespace StaffApplication.Models
{
    public class Staff
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }
    }
}
