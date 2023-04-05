using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StaffApplication.Data;
using StaffApplication.Entity;
using StaffApplication.Models;

namespace StaffApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly StaffContext _staffContext;

        //public IndexModel(ILogger<IndexModel> logger, StaffContext staffContext)
        //{ 
        //    _logger = logger;
        //    _staffContext = staffContext;

        //}

        private readonly IRepository<Staff> repository;
        public IndexModel(IRepository<Staff> repository, ILogger<IndexModel> logger)
        {
            this._logger = logger;
            this.repository = repository;
        }

        [BindProperty]
        public Staff movie { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
                await repository.CreateAsync(movie);
            return Page();
        }

    }
}