using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Services.Streams
{
    internal class SpendingService
    {
        private readonly IRepository<Spending> _repository;

        public SpendingService()
        {
            _repository = new Repository<Spending>("PersofinData.db", "PersofinData");
        }

        public void AddSpending(Spending spending) => _repository.Add(spending);
        public List<Spending> GetAllSpendings() => _repository.GetAll();
        public Spending? GetSpendingById(int id) => _repository.GetById(id);
        public bool UpdateSpending(Spending spending) => _repository.Update(spending);
        public bool DeleteSpending(int id) => _repository.Delete(id);
    }
}
