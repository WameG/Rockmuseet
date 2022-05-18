using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Rockmuseet.models;

namespace Rockmuseet.Helpers
{
    public class JsonFileReader
    {
            public static List<History> ReadJsonHistory(string JsonFileName)
            {
                string jsonString = File.ReadAllText(JsonFileName);

            return JsonSerializer.Deserialize<List<History>>(jsonString);
            }
        }
}
