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
            Exhibits.Add(1, new Exhibit() {Id = 1,Name = "guitar", Description = "Guitaren bliver brugt som en af de vigtigste instrumenter i et rockband, næsten alle bands har minimum 1 guitar med ", Imagename = "Guitar.JPEG",Soundname = "Guitar.mp3" });
            Exhibits.Add(2, new Exhibit() {Id = 2,Name = "Blokfløjte",Description = "Blokfløjten har en fantisk lyd og man kan spille en masse melodiere på en blokføjte", Imagename = "BlokFløjte.JPEG",Soundname = "Recorder.mp3" });
            Exhibits.Add(3, new Exhibit() {Id = 3,Name = "Bass",Description = "Bass er ligesom guitaren en af de vigtiste instrumenter og har en fantastisk dyb melodi.", Imagename = "Bass.JPEG",Soundname = "Bass.mp3" });
            Exhibits.Add(4, new Exhibit() {Id = 4,Name = "Keyboard",Description = "Keyboard er et fantastisk instrument som kan bruges i næsten alle former for musik, man kan næsten spille alle lyde og melodier på et keyboard.", Imagename = "Keyboard.JPEG",Soundname = "Piano.mp3" });
            Exhibits.Add(5, new Exhibit() {Id = 5,Name = "trummer",Description = "Trummerne er et af de fedeste instrumenter i musikverden, næsten alle bands har en trommeslager.", Imagename = "trummer.JPEG",Soundname = "Drums.mp3" });

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
