using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Services.Streams
{
    internal class AssetService
    {
        private readonly IRepository<Asset> _repository;

        public AssetService()
        {
            _repository = new Repository<Asset>("PersofinData.db", "Assets");
        }

        public void AddAsset(Asset asset) => _repository.Add(asset);
        public List<Asset> GetAllAssets() => _repository.GetAll();
        public Asset? GetAssetById(int id) => _repository.GetById(id);
        public bool UpdateAsset(Asset asset) => _repository.Update(asset);
        public bool DeleteAsset(int id) => _repository.Delete(id);
    }
}
