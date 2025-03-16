using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TitanicSurvival.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PredictorService _predictorService;
        public IndexModel(ILogger<IndexModel> logger, PredictorService predictorService)
        {
            _logger = logger;
            _predictorService = predictorService;
        }

        [BindProperty]
        public int Age { get; set; }

        [BindProperty]
        public string Sex { get; set; } = string.Empty;

        [BindProperty]
        public int TicketClass { get; set; }

        public IActionResult OnPost()
        {
           var isSurvived=_predictorService.CanSurvive(new Passenger { Age = Age, Sex = Sex, TicketClass = TicketClass });
            TempData["IsSurvived"] = isSurvived;
            TempData["Message"] = isSurvived ? "Survived!" : "Did not survive.";

            return Page();
        }

        public void OnGet()
        {

        }
    }
}
