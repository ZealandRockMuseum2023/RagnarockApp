using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarockApp.Interfaces;
using RagnarockApp.Models;

namespace RagnarockApp.Pages.Exhibits
{
    public class DeleteExhibitModel : PageModel
    {
        IExhibit catalog;

        [BindProperty]
        public Exhibit Exhibit { get; set; }

        public DeleteExhibitModel(IExhibit cat)
        { 
            catalog = cat;
        }
        
        public IActionResult OnGet(int Id)
        {
            Exhibit = catalog.GetExhibit(Id);
            return Page();
        }

        public IActionResult OnPost() 
        {
            catalog.DeleteExhibit(Exhibit);
            return RedirectToPage("GetAllExhibits");
        }
    }
}
