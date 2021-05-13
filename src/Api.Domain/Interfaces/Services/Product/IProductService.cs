using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Product
{
   public interface IProductService
    {
        Task<ProductDTO> Get(Guid id);
        Task<IEnumerable<ProductDTO>> GetAll();
        Task<ProductCreateResultDTO> Post(ProductDTO product);
        Task<ProductUpdateResultDTO>Put(ProductDTO product);
        Task<bool> Delete(Guid id);
    }
}
