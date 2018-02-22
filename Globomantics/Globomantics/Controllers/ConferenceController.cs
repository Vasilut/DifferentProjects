using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globomantics.Controllers
{
    public class ConferenceController : Controller
    {
        private IConferenceService _conferenceService;

        public ConferenceController(IConferenceService conferenceService)
        {
            _conferenceService = conferenceService;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = " Conference room";
            var data = await _conferenceService.GetAll();
            return View(data);
        }

        public IActionResult Add()
        {
            ViewBag.Title = "Add Conference";
            return View(new ConferenceModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(ConferenceModel model)
        {
            if(ModelState.IsValid)
            {
                await _conferenceService.Add(model);
            }
            return RedirectToAction("Index");
        }
    }
}
