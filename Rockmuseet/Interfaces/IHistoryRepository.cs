using System;
using System.Collections.Generic;
using Rockmuseet.models;

namespace Rockmuseet.Interfaces
{
        public interface IHistoryRepository
        {
        List<History> GetAllHistories();
        }
}
