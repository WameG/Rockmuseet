using System;
using System.Collections.Generic;
using System.IO;
using Rockmuseet.models;

namespace Rockmuseet.Helpers
{
    public class JsonFileWritter
    {
            public static void WriteToJsonBook(List<History> history, string JsonFileName)
            {
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(history, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(JsonFileName, output);
            }
        }
}
