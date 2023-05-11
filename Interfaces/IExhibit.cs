using RagnarockApp.Models;
using RagnarockApp.Services;

namespace RagnarockApp.Interfaces
{
    public interface IExhibit
    {
        Dictionary<int, Exhibit> AllExhibits();

        Dictionary<int, Exhibit> FilterExhibit(string criteria);

        public void AddExhibit(Exhibit exhibit);

        public void DeleteExhibit(Exhibit exhibit);

        public void UpdateExhibit(Exhibit exhibit);

        public Exhibit GetExhibit(int Id);
    }
}
