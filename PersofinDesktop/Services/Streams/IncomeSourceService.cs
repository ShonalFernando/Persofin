using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Services.Streams
{
    internal class IncomeSourceService
    {
        private readonly IRepository<IncomeSourceService> _repository;

        public IncomeSourceService()
        {
            _repository = new Repository<IncomeSourceService>("PersofinData.db", "PersofinData");
        }

        public void AddIncomeSource(IncomeSourceService incomeSource) => _repository.Add(incomeSource);
        public List<IncomeSourceService> GetAllIncomeSources() => _repository.GetAll();
        public IncomeSourceService? GetIncomeSourceById(int id) => _repository.GetById(id);
        public bool UpdateIncomeSource(IncomeSourceService incomeSource) => _repository.Update(incomeSource);
        public bool DeleteIncomeSource(int id) => _repository.Delete(id);
    }
}
