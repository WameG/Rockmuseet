using System;
using System.Collections.Generic;
using Rockmuseet.Helpers;
using Rockmuseet.Interfaces;
using Rockmuseet.models;

namespace Rockmuseet.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        string JsonFileName = @"Data/Histories.json";

        public List<History> GetAllHistories()
        {
            Console.WriteLine(JsonFileName);
            return JsonFileReader.ReadJsonHistory(JsonFileName);
        }
    }
}
