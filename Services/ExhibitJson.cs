using RagnarockApp.Helpers;
using RagnarockApp.Interfaces;
using RagnarockApp.Models;
using RagnarockApp.Services;
using System.Collections.Generic;
using System.Linq;


namespace RagnarockApp.Services
{
    public class ExhibitJson : IExhibit
    {
        public void AddExhibit(Exhibit exhibit)
        {

            Dictionary<int, Exhibit> exhibits = AllExhibits();
            if (!(exhibits.Keys.Contains(exhibit.Id)))
                exhibits.Add(exhibit.Id, exhibit);
            JsonFileWriter.WriteToJson(exhibits, @"data\Exhibitjson.json");
            
        }

        public Dictionary<int, Exhibit> AllExhibits()
        {
            return JsonFileReader.ReadJson(@"data\Exhibitjson.json");
        }

        public void DeleteExhibit(Exhibit exhibit)
        {
            Dictionary<int, Exhibit> exhibits = AllExhibits();
            exhibits.Remove(exhibit.Id);
            JsonFileWriter.WriteToJson(exhibits,@"data\Exhibitjson.json");
        }

        public Dictionary<int, Exhibit> FilterExhibit(string criteria)
        {
            Dictionary<int, Exhibit> Exhibits = AllExhibits();
           
            Dictionary<int, Exhibit> filteredexhibits = new Dictionary<int, Exhibit>();
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

        public Exhibit GetExhibit(int Id)
        {
            Dictionary<int, Exhibit> exhibits = AllExhibits();
            Exhibit foundexhibit = exhibits[Id];
            return foundexhibit;
        }

        public void UpdateExhibit(Exhibit exhibit)
        {
            if (exhibit != null)
            { 
                Dictionary<int, Exhibit> exhibits = AllExhibits();
            
                Exhibit foundexhibits = exhibits[exhibit.Id];
                //foundexhibits.Id = exhibit.Id;
                foundexhibits.Name = exhibit.Name;
                foundexhibits.Description = exhibit.Description;
                foundexhibits.Imagename = exhibit.Imagename;
                JsonFileWriter.WriteToJson(exhibits,@"data\Exhibitjson.json");
            }    
            
        }
    }
}

           
