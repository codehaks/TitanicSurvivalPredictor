using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TitanicSurvival.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public int Age { get; set; }

        [BindProperty]
        public string Sex { get; set; } = string.Empty;

        [BindProperty]
        public int TicketClass { get; set; }

        public IActionResult OnPost()
        {
            // Placeholder: Use the ML model to predict survival here.
            bool isSurvived = (Age < 10 && Sex == "female") || (TicketClass == 1 && Age < 30); // Temporary logic

            TempData["IsSurvived"] = isSurvived;
            TempData["Message"] = isSurvived ? "Survived!" : "Did not survive.";

            return Page();
        }

        public void OnGet()
        {

        }
    }
}
