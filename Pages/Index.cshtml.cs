using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StaffApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string myFirstTextLiteral;
        public string Name => (string)TempData[nameof(Name)];
        public void OnGet()
        {
            this.myFirstTextLiteral = "Hello, world!";
        }
        public IActionResult OnPost([FromForm] string name)
        {
            TempData["Name"] = name;
            return RedirectToPage("Index");
        }

    }
}