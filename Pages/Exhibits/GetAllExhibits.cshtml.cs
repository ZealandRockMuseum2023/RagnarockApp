using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarockApp.Interfaces;
using RagnarockApp.Models;

namespace RagnarockApp.Pages.Exhibits
{
    public class GetAllExhibitsModel : PageModel
    {

        IExhibit catalog;

        public GetAllExhibitsModel(IExhibit cat)
        { 
            catalog = cat;
        }


        public Dictionary<int,Exhibit> Exhibits { get; set; }
        public Dictionary<int,Exhibit> FilteredExhibit { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Filtercriteria { get; set; }


        public IActionResult OnGet()
        {
            Exhibits = catalog.AllExhibits();
            if (!string.IsNullOrEmpty(Filtercriteria))
            {
                Exhibits = catalog.FilterExhibit(Filtercriteria);
            }
            else
            {
                Exhibits = catalog.AllExhibits();
            }
            return Page();
        }
    }
}
