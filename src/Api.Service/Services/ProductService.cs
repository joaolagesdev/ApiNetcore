using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private IRepository<ProductEntity> _repository; // Subistituição do <T>

        public ProductService(IRepository<ProductEntity> repository) // Injeção 
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ProductEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<ProductEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<ProductEntity> Post(ProductEntity user)
        {   // Pode aplicar uma regra de negócio
            return await _repository.InsertAsync(user);
        }

        public async Task<ProductEntity> Put(ProductEntity user)
        {
            return await _repository.UpdateAsync(user);
        }
    }
}
