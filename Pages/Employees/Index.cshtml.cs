using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StaffApplication.Entity;
using StaffApplication.Models;

namespace StaffApplication.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<Staff> repository;
        public IndexModel(IRepository<Staff> repository)
        {
            this.repository = repository;
        }

        public List<Staff> staffList { get; set; }

        public async Task OnGet()
        {
            staffList = await repository.ReadAllAsync();
        }
    }
}
