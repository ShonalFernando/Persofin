using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Services.Streams
{
    /// <summary>
    /// The Repository Pattern eliminates rewriting of streaming classes!
    /// </summary>
    internal class Repository<T> : IRepository<T>
    {
        private readonly LiteDatabase _db;
        private readonly string _collectionName;

        public Repository(string databasePath, string collectionName)
        {
            _db = new LiteDatabase(databasePath);
            _collectionName = collectionName;
        }

        public void Add(T entity)
        {
            var collection = _db.GetCollection<T>(_collectionName);
            collection.Insert(entity);
        }

        public List<T> GetAll()
        {
            var collection = _db.GetCollection<T>(_collectionName);
            return collection.FindAll().ToList();
        }

        public T? GetById(int id)
        {
            var collection = _db.GetCollection<T>(_collectionName);
            return collection.FindById(id);
        }

        public bool Update(T entity)
        {
            var collection = _db.GetCollection<T>(_collectionName);
            return collection.Update(entity);
        }

        public bool Delete(int id)
        {
            var collection = _db.GetCollection<T>(_collectionName);
            return collection.Delete(id);
        }
    }
}
