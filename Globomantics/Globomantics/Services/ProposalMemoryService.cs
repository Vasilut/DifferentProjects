using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Models;

namespace Globomantics.Services
{
    public class ProposalMemoryService : IProposalService
    {
        private List<ProposalModel> _proposals = new List<ProposalModel>();

        public ProposalMemoryService()
        {
            _proposals.Add(new ProposalModel
            {
                Id = 1,
                ConferenceId = 1,
                Speaker = "Lucian",
                Title = "Cenusareasa"
            });

            _proposals.Add(new ProposalModel
            {
                Id = 2,
                ConferenceId = 2,
                Speaker = "Lucian2",
                Title = "Cenusareasa2"
            });

            _proposals.Add(new ProposalModel
            {
                Id = 3,
                ConferenceId = 2,
                Speaker = "Lucian2",
                Title = "Cenusareasa2"
            });
        }
        public Task Add(ProposalModel model)
        {
            model.Id = _proposals.Max(p => p.Id) + 1;
            _proposals.Add(model);
            return Task.CompletedTask;
        }

        public Task<ProposalModel> Approve(int proposalId)
        {
            return Task.Run(
                () =>
                {
                    var proposal = _proposals.First(p => p.Id == proposalId);
                    proposal.Approved = true;
                    return proposal;
                });
        }

        public Task<IEnumerable<ProposalModel>> GetAll(int conferenceId)
        {
            return Task.Run(() => _proposals.AsEnumerable());
        }
    }
}
