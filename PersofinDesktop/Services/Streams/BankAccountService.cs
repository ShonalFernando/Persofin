using LiteDB;
using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Services.Streams
{
    internal static class BankAccountService
    {
        private static readonly string _databasePath = "PersofinData.db";

        public static void AddBankAccount(BankAccount account)
        {
            using (var db = new LiteDatabase(_databasePath))
            {
                var collection = db.GetCollection<BankAccount>("PersofinData");
                collection.Insert(account);
            }
        }

        public static List<BankAccount> GetAllBankAccounts()
        {
            using (var db = new LiteDatabase(_databasePath))
            {
                var collection = db.GetCollection<BankAccount>("PersofinData");
                return collection.FindAll().ToList();
            }
        }

        public static BankAccount? GetBankAccountById(int id)
        {
            using (var db = new LiteDatabase(_databasePath))
            {
                var collection = db.GetCollection<BankAccount>("PersofinData");
                return collection.FindById(id);
            }
        }

        public static bool UpdateBankAccount(BankAccount account)
        {
            using (var db = new LiteDatabase(_databasePath))
            {
                var collection = db.GetCollection<BankAccount>("PersofinData");
                return collection.Update(account);
            }
        }

        public static bool DeleteBankAccount(int id)
        {
            using (var db = new LiteDatabase(_databasePath))
            {
                var collection = db.GetCollection<BankAccount>("PersofinData");
                return collection.Delete(id);
            }
        }
    }
}
