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
            _repository = new Repository<UserAccount>("PersofinData.db", "UserAccounts");
        }

        public void AddUserAccount (UserAccount userAccount) => _repository.Add(userAccount);
        public List<UserAccount> GetAllUserAccounts() => _repository.GetAll();
        public UserAccount? GetUserAccountById(int id) => _repository.GetById(id);
        public bool UpdateUserAccount(UserAccount userAccount) => _repository.Update(userAccount);
        public bool DeleteUserAccount(int id) => _repository.Delete(id);
    }
}
