using LiteDB;
using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Services.Streams
{
    internal class BankAccountService
    {
        private readonly IRepository<BankAccount> _repository;

        public BankAccountService()
        {
            _repository = new Repository<BankAccount>("PersofinData.db", "PersofinData");
        }

        public void AddBankAccount(BankAccount account) => _repository.Add(account);
        public List<BankAccount> GetAllBankAccounts() => _repository.GetAll();
        public BankAccount? GetBankAccountById(int id) => _repository.GetById(id);
        public bool UpdateBankAccount(BankAccount account) => _repository.Update(account);
        public bool DeleteBankAccount(int id) => _repository.Delete(id);
    }
}
