using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarockApp.Interfaces;
using RagnarockApp.Models;

namespace RagnarockApp.Pages.Exhibits
{
    public class UpdateExhibitModel : PageModel
    {
        IExhibit catalog;
        [BindProperty]
        public Exhibit Exhibit { get; set; }



        public UpdateExhibitModel(IExhibit cat) 
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
            if (!ModelState.IsValid)
            { 
                return Page();
            }
            catalog.UpdateExhibit(Exhibit);
            return RedirectToPage("GetAllExhibits");
        }
    }
}
