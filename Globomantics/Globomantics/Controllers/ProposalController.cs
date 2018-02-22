using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globomantics.Controllers
{
    public class ProposalController:Controller
    {
        private IConferenceService _conferenceService;
        private IProposalService _proposalService;

        public ProposalController(IConferenceService conferenceService, IProposalService proposalService)
        {
            _conferenceService = conferenceService;
            _proposalService = proposalService;
        }

        public async Task<IActionResult> Index(int conferenceId)
        {
            var conference = await _conferenceService.GetById(conferenceId);
            ViewBag.Title = $"Proposals for conference {conference.Name} {conference.Location}";

            var proposals = await _proposalService.GetAll(conferenceId);
            return View(proposals);
        }

        public IActionResult Add(int conferenceId)
        {
            ViewBag.Title = "Add proposal";
            return View(new ProposalModel { Id = conferenceId });
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProposalModel proposal)
        {
            if(ModelState.IsValid)
            {
                await _proposalService.Add(proposal);
            }
            return RedirectToAction("Index", new { conferenceId = proposal.Id });
        }

        public async Task<IActionResult> Approve(int proposalId)
        {
            var proposal = await _proposalService.Approve(proposalId);
            return RedirectToAction("Index", new { conferenceId = proposal.ConferenceId });
        }
    }
}
