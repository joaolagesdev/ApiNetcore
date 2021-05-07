using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Product
{
   public interface IProductService
    {
        Task<ProductEntity> Get(Guid id);
        Task<IEnumerable<ProductEntity>> GetAll();
        Task<ProductEntity> Post(ProductEntity user);
        Task<ProductEntity> Put(ProductEntity user);
        Task<bool> Delete(Guid id);
    }
}
