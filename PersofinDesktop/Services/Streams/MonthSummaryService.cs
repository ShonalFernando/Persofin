using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Services.Streams
{
    internal class MonthSummaryService
    {
        private readonly IRepository<MonthSummary> _repository;

        public MonthSummaryService()
        {
            _repository = new Repository<MonthSummary>("PersofinData.db", "PersofinData");
        }

        public void AddMonthSummary(MonthSummary monthSummary) => _repository.Add(monthSummary);
        public List<MonthSummary> GetAllMonthSummarys() => _repository.GetAll();
        public MonthSummary? GetMonthSummaryById(int id) => _repository.GetById(id);
        public bool UpdateMonthSummary(MonthSummary monthSummary) => _repository.Update(monthSummary);
        public bool DeleteMonthSummary(int id) => _repository.Delete(id);
    }
}
