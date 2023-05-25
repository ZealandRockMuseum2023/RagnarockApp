using RagnarockApp.Interfaces;
using RagnarockApp.Models;

namespace RagnarockApp.Services
{
    public class ExhibitCatalog : IExhibit
    {

        public Dictionary<int,Exhibit> Exhibits {get;}

        public ExhibitCatalog() 
        { 
            Exhibits = new Dictionary<int,Exhibit>();
            Exhibits.Add(1, new Exhibit() {Id = 1,Name = "Exhibit 1", Description = "guitar 1", Imagename = "Guitarist.JPEG",Soundname = "Ronaldo suiii.mp3" });
            Exhibits.Add(2, new Exhibit() {Id = 2,Name = "Exhibit 2", Description = "guitar 2", Imagename = "RockBand.JPEG",Soundname = "Ankara_messi.mp3.mp3" });
            Exhibits.Add(3, new Exhibit() {Id = 3,Name = "exhibit 3", Description = "guitar 3", Imagename = "RockBand2.JPEG",Soundname = "funnysound.mp3.mp3" });
            Exhibits.Add(4, new Exhibit() {Id = 4,Name = "exhibit 4", Description = "guitar 4", Imagename = "PopBandSinger.JPEG",Soundname = "shutyourmouth.mp3.mp3" });
            Exhibits.Add(5, new Exhibit() {Id = 5,Name = "exhibit 5", Description = "guitar 5", Imagename = "PopBand.JPEG",Soundname = "whoisthatguy.mp3.mp3" });

        }

        public Dictionary<int,Exhibit> AllExhibits()
        { 
            return Exhibits; 
        }

        public void AddExhibit(Exhibit exhibit)
        {
            Exhibits.Add(exhibit.Id, exhibit);
        }

        public Exhibit GetExhibit(int Id)
        { 
            return Exhibits[Id];
        }

       

        public void UpdateExhibit(Exhibit exhibit)
        {
            if (exhibit != null)
            {
                Exhibits[exhibit.Id] = exhibit;
            }
        }

        public void DeleteExhibit(Exhibit exhibit)
        {
            if (exhibit != null)
            { 
                Exhibits.Remove(exhibit.Id);
            }
        }

        public Dictionary<int, Exhibit> FilterExhibit(string criteria)
        { 
            Dictionary<int,Exhibit> filteredexhibits = new Dictionary<int, Exhibit>();
            if (criteria != null)
            {
                foreach (var e in Exhibits.Values)
                {
                    if (e.Name.ToLower().StartsWith(criteria.ToLower()))
                    { 
                        filteredexhibits.Add(e.Id, e);
                    }
                }
            }
        
            return filteredexhibits;
        }
                
            
            
            
    }
}
