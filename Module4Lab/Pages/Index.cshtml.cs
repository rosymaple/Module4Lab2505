using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Lab.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string[] Shows { get; set; } = new string[3];

        public string[] SampleShows { get; set; }
        public bool ShowResults { get; set; } = false;

        public void OnGet()
        {
            SampleShows = new string[] { "A Christmas Carol", "Hamlet", "The Crucible" };
        }

        public IActionResult OnPost()
        {
            SampleShows = new string[] { "A Christmas Carol", "Hamlet", "The Crucible" };
            ShowResults = true;
            return Page();
        }
    }
}

