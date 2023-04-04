using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StaffApplication.Data;
using StaffApplication.Models;

namespace StaffApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly StaffContext _staffContext;

        public IndexModel(ILogger<IndexModel> logger, StaffContext staffContext)
        { 
            _logger = logger;
            _staffContext = staffContext;

        }

        public List<Staff> AllStaffList = new List<Staff>();

        public async Task<IActionResult> OnGetAsync()
        {
            AllStaffList = await _staffContext.Staff?.ToListAsync();
            return Page();
        }

    }
}