using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rockmuseet.Interfaces;
using Rockmuseet.models;

namespace Rockmuseet.Pages.Admin
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public History History { get; set; }

        private IHistoryRepository historyRepository;

        public UpdateModel(IHistoryRepository repository)
        {
            historyRepository = repository;
        }

        public void OnGet(int id)
        {
            History = historyRepository.GetHistory(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Random rnd = new Random();

            //var histories = historyRepository.GetAllHistories();

            //var HistoryAudioId = rnd.Next(0, 10000);
            //var MusicAudioId = rnd.Next(0, 10000);

            //foreach (var item in histories)
            //{

            //    if (item.Value.HistoryAudioId != HistoryAudioId)
            //    {
            //        History.HistoryAudioId = HistoryAudioId;
            //    }

            //    if (item.Value.MusicAudioId != MusicAudioId)
            //    {
            //        History.MusicAudioId = MusicAudioId;
            //    }
            //}

            historyRepository.UpdateHistory(History);

            return RedirectToPage("Index");
        }
    }
}
