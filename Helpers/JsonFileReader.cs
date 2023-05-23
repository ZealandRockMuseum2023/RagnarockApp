using Newtonsoft.Json;
using RagnarockApp.Models;

namespace RagnarockApp.Helpers
{
    public class JsonFileReader
    {
        public static Dictionary<int, Exhibit> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<Dictionary<int, Exhibit>>(jsonString);
        }
    }
}
