using System;
using PersofinDesktop.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Services.Streams
{
    internal class DebtOrLoanService
    {
        private readonly IRepository<DebtOrLoan> _repository;

        public DebtOrLoanService()
        {
            _repository = new Repository<DebtOrLoan>("PersofinData.db", "Loans");
        }

        public void AddDebtOrLoan(DebtOrLoan loan) => _repository.Add(loan);
        public List<DebtOrLoan> GetAllDebtOrLoans() => _repository.GetAll();
        public DebtOrLoan? GetDebtOrLoanById(int id) => _repository.GetById(id);
        public bool UpdateDebtOrLoan(DebtOrLoan loan) => _repository.Update(loan);
        public bool DeleteDebtOrLoan(int id) => _repository.Delete(id);
    }
}
