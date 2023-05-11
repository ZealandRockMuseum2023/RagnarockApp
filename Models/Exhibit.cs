using System;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RagnarockApp.Models
{
    public class Exhibit
    {

        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Imagename { get; set; }

    }
}
