using RagnarockApp.Models;

namespace RagnarockApp.Helpers
{
    public class JsonFileWriter
    {

        public static void WriteToJson(Dictionary<int, Exhibit> exhibit, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(exhibit,
                                                               Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(JsonFileName, output);
      
        }
    }
}
