using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globomantics.Services
{
    public class ConferenceMemoryService:IConferenceService
    {
        private List<ConferenceModel> _conferences = new List<ConferenceModel>();
        public ConferenceMemoryService()
        {
            _conferences.Add(new ConferenceModel { Id = 1, Name = "Luc1", Location = "Bucuresti", Start = DateTime.Now, AttendeeTotal = 9 });
            _conferences.Add(new ConferenceModel { Id = 2, Name = "Luc2", Location = "Cluj", Start = DateTime.Now, AttendeeTotal = 15 });

        }

        public Task Add(ConferenceModel model)
        {
            model.Id = _conferences.Max(c => c.Id) + 1;
            _conferences.Add(model);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<ConferenceModel>> GetAll()
        {
            return Task.Run(() => _conferences.AsEnumerable());
        }

        public Task<ConferenceModel> GetById(int id)
        {
            return Task.Run(() => _conferences.First(c => c.Id == id));
        }

        public Task<StatisticsModel> GetStatistics()
        {
            return Task.Run(() =>
            {
                return new StatisticsModel
                {
                    NumberOfAttendees = _conferences.Sum(c => c.AttendeeTotal),
                    AverageConferenceAttendees = (int)_conferences.Average(c => c.AttendeeTotal)
                };
            });
        }
    }
}
