using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StaffApplication.Entity;
using StaffApplication.Models;

namespace StaffApplication.Pages.Employees
{
    public class StaffModel : PageModel
    {
      
            private readonly IRepository<Staff> repository;
            public StaffModel(IRepository<Staff> repository)
            {
                this.repository = repository;
            }

            [BindProperty]
            public Staff staff { get; set; }

            public IActionResult OnGet()
            {
                return Page();
            }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
                await repository.CreateAsync(staff);
            return Page();
        }



      
    }
}
