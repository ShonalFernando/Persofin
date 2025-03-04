using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Services.Streams
{
    internal class UserAccountService
    {
        private readonly IRepository<UserAccount> _repository;

        public UserAccountService()
        {
            _repository = new Repository<UserAccount>("PersofinData.db", "PersofinData");
        }

        public void AddIncomeSource(UserAccount userAccount) => _repository.Add(userAccount);
        public List<UserAccount> GetAlluserAccounts() => _repository.GetAll();
        public UserAccount? GetuserAccountById(int id) => _repository.GetById(id);
        public bool UpdateuserAccount(UserAccount userAccount) => _repository.Update(userAccount);
        public bool DeleteuserAccount(int id) => _repository.Delete(id);
    }
}
