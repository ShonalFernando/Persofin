using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Services.Streams
{
    internal interface IRepository<T>
    {
        void Add(T entity);
        List<T> GetAll();
        T? GetById(int id);
        bool Update(T entity);
        bool Delete(int id);
    }
}
