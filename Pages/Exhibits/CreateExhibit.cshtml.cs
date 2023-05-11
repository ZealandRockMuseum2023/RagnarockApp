using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarockApp.Interfaces;
using RagnarockApp.Models;

namespace RagnarockApp.Pages.Exhibits
{
    public class CreateExhibitModel : PageModel
    {

        IExhibit catalog;
        [BindProperty]
        public Exhibit exhibit { get; set; }

        public CreateExhibitModel(IExhibit Cat)
        { 
            catalog = Cat;
        }

        public IActionResult OnGet()
        { 
            return Page();
        }

        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.AddExhibit(exhibit);
            return RedirectToPage("GetAllExhibits");

        }
        
    }
}
