using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Services.Streams
{
    internal class RecievedService
    {
        private readonly IRepository<Recieved> _repository;

        public RecievedService()
        {
            _repository = new Repository<Recieved>("PersofinData.db", "Reciepts");
        }

        public void AddRecieved(Recieved recieved) => _repository.Add(recieved);
        public List<Recieved> GetAllRecieveds() => _repository.GetAll();
        public Recieved? GetRecievedById(int id) => _repository.GetById(id);
        public bool UpdateRecieved(Recieved recieved) => _repository.Update(recieved);
        public bool DeleteRecieved(int id) => _repository.Delete(id);
    }
}
