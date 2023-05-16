using System;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RagnarockApp.Models
{
    public class Exhibit
    {

        public int Id { get; set; } 

        [Display(Name = "Exhibition name")]
        [Required(ErrorMessage = "Name of Exhibition is required"), MaxLength(150)]
        
        public string Name { get; set; }
        
        [Display(Description = "Description of Exhibition")]
        [Required(ErrorMessage = "Descriptionen of Exhibition is required"), MaxLength(500)]
        public string Description { get; set; }
        
        public string Imagename { get; set; }

    }
}
